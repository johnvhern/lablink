(() =>
{
    if (window.lablinkResultsInitialized) return;
    window.lablinkResultsInitialized = true;

    let activeTable = null;
    let searchTimer;
    function initializeResultsTable()
    {
        const wrapper = document.getElementById("resultsDatatable");
        const searchInput = document.getElementById("resultsSearch");

        if (!wrapper || !searchInput || activeTable?.wrapper === wrapper) return;
        const instance = new HSDataTable(wrapper, {
            autoWidth: true,
            processing: true,
            serverSide: true,
            orderMulti: false,
            order: [[0, "asc"]],

            ajax: {
                url: wrapper.dataset.resultsUrl,
                type: "GET"
            },

            createdRow: (row) =>
            {
                row.classList.add("hover:bg-gray-100", "dark:hover:bg-neutral-700");
            },

            columns: [
                {
                    data: "refNo",
                    render: DataTable.render.text()
                },
                {
                    data: "name",
                    render: DataTable.render.text()
                },
                {
                    data: "testType",
                    render: DataTable.render.text()
                },
                {
                    data: "resultStatus",
                    searchable: false,
                    render: (value, type) =>
                    {
                        if (type !== "display") return value; // keeps sorting/filtering on plain text

                        return {
                            0: "Pending",
                            1: "Ready for Claim",
                            2: "Claimed"
                        }[value] ?? "Unknown";
                    }
                },
                {
                    data: "readyAt",
                    searchable: false,
                    defaultContent: "—",
                    render: DataTable.render.text()
                },
                {
                    data: "claimedAt",
                    searchable: false,
                    defaultContent: "—",
                    render: DataTable.render.text()
                },
                {
                    data: null,
                    orderable: false,
                    searchable: false,
                    render: (data, type, row) =>
                    {
                        if (type !== "display") return "";

                        return `
            <div class="inline-flex gap-x-2">
                <button type="button" hx-sync="#crudModalContent:replace" hx-get="/Results/Edit/${row.id}" hx-target="#crudModalContent" hx-swap="innerHTML" hx-disabled-elt="this" class="py-2 px-3 inline-flex items-center gap-x-2 text-sm font-medium rounded-lg bg-blue-100 border border-transparent text-blue-800 hover:bg-blue-200 focus:outline-hidden focus:bg-blue-200 disabled:opacity-50 disabled:pointer-events-none dark:text-blue-400 dark:bg-blue-800/30 dark:hover:bg-blue-500/20 dark:focus:bg-blue-500/20">View</button>`;
                    }
                }
            ],

            columnDefs: [
                {
                    targets: "_all",
                    className: "p-3 whitespace-nowrap text-sm text-gray-800 dark:text-neutral-200"
                },
                {
                    targets: 6,
                    className: "text-end"
                }
            ]
        });

        const resultsTable = instance.dataTable;
        activeTable = { wrapper, instance, resultsTable };

        // Preline counts locally loaded rows; server-side paging must use page.info().
        const paging = wrapper.querySelector("[data-hs-datatable-paging]");
        const pageButtons = wrapper.querySelector("[data-result-paging-pages]");
        const previous = wrapper.querySelector("[data-hs-datatable-paging-prev]");
        const next = wrapper.querySelector("[data-hs-datatable-paging-next]");
        const buttonClasses = JSON.parse(wrapper.getAttribute("data-hs-datatable"))
            .pagingOptions.pageBtnClasses;

        function renderPagination()
        {
            const { page, pages, start, end, recordsDisplay } = resultsTable.page.info();
            paging.classList.toggle("hidden", pages < 2);
            paging.style.display = pages < 2 ? "none" : "";
            previous.disabled = page === 0 || pages === 0;
            next.disabled = pages === 0 || page >= pages - 1;
            pageButtons.replaceChildren();

            // Keep rendering bounded even when the directory contains many pages.
            const visiblePages = new Set();
            if (pages > 0)
            {
                visiblePages.add(0);
                visiblePages.add(pages - 1);
                for (let index = Math.max(0, page - 1); index <= Math.min(pages - 1, page + 1); index++)
                {
                    visiblePages.add(index);
                }
            }
            let lastPage = -1;
            for (const index of [...visiblePages].sort((a, b) => a - b))
            {
                if (lastPage !== -1 && index - lastPage > 1)
                {
                    const ellipsis = document.createElement("span");
                    ellipsis.textContent = "…";
                    pageButtons.append(ellipsis);
                }
                const button = document.createElement("button");
                button.type = "button";
                button.className = buttonClasses;
                button.textContent = String(index + 1);
                button.dataset.page = String(index);
                button.setAttribute("aria-label", `Page ${index + 1}`);
                if (index === page)
                {
                    button.classList.add("active");
                    button.setAttribute("aria-current", "page");
                }
                pageButtons.append(button);
                lastPage = index;
            }
            wrapper.querySelector("[data-hs-datatable-info-from]").textContent = recordsDisplay ? start + 1 : 0;
            wrapper.querySelector("[data-hs-datatable-info-to]").textContent = end;
            wrapper.querySelector("[data-hs-datatable-info-length]").textContent = recordsDisplay;
        }

        pageButtons.addEventListener("click", event =>
        {
            const button = event.target.closest("button[data-page]");
            if (!button || !pageButtons.contains(button)) return;
            resultsTable.page(Number(button.dataset.page)).draw("page");
        });
        resultsTable.on("draw", () =>
        {
            // A deletion can remove the current server-side page entirely.
            const { page, pages } = resultsTable.page.info();
            const lastPage = Math.max(0, pages - 1);
            if (page > lastPage)
            {
                resultsTable.page(lastPage).draw("page");
                return;
            }

            renderPagination();
            htmx.process(wrapper);
            window.HSOverlay.autoInit();
        });

        searchInput.addEventListener("input", () =>
        {
            clearTimeout(searchTimer);

            searchTimer = setTimeout(() =>
            {
                resultsTable.search(searchInput.value).draw();
            }, 350);
        });

    }

    htmx.onLoad(initializeResultsTable);
    if (document.readyState === "loading")
    {
        document.addEventListener("DOMContentLoaded", initializeResultsTable, { once: true });
    } else
    {
        initializeResultsTable();
    }
    document.addEventListener("dataUpdated", () =>
    {
        activeTable?.resultsTable.ajax.reload(null, false);
    });
    document.addEventListener("htmx:beforeCleanupElement", event =>
    {
        if (!activeTable || !event.detail.elt.contains(activeTable.wrapper)) return;
        clearTimeout(searchTimer);
        const { instance } = activeTable;
        activeTable = null;
        instance.destroy();
    });
})();
