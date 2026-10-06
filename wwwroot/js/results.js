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

        let appliedFilters = {
            status: "",
            fromDate: "",
            toDate: ""
        };

        const instance = new HSDataTable(wrapper, {
            autoWidth: true,
            processing: true,
            serverSide: true,
            orderMulti: false,
            order: [[0, "asc"]],

            ajax: {
                url: wrapper.dataset.resultsUrl,
                type: "GET",
                data: function (request)
                {
                    request.status = appliedFilters.status;
                    request.fromDate = appliedFilters.fromDate;
                    request.toDate = appliedFilters.toDate;
                }
            },

            createdRow: (row) =>
            {
                row.classList.add("hover:bg-gray-100", "dark:hover:bg-neutral-700");
            },

            columns: [
                {
                    data: null,
                    searchable: false,
                    orderable: false,
                    render: (data, type) =>
                    {
                        if (type !== "display") return "";

                        return `<input type="checkbox"data-hs-datatable-row-selecting-individual aria-label="Select result" class="shrink-0 size-4 bg-transparent border-gray-300 dark:border-neutral-600 rounded-sm shadow-2xs text-blue-600 dark:text-blue-500 focus:ring-0 focus:ring-offset-0 checked:bg-blue-600 dark:checked:bg-blue-500 checked:border-blue-600 dark:checked:border-blue-500 disabled:opacity-50 disabled:pointer-events-none">`;
                    }
                },
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

                        const baseClass = "py-1 px-2 inline-flex items-center gap-x-1 text-xs font-medium rounded-full"

                        switch (value)
                        {
                            case 0:
                                return `<div><span class="${baseClass} bg-gray-100 dark:bg-neutral-700 text-gray-800 dark:text-neutral-200">
                                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-loader preview-icon shrink-0 size-3"><path d="M12 2v4"/><path d="m16.2 7.8 2.9-2.9"/><path d="M18 12h4"/><path d="m16.2 16.2 2.9 2.9"/><path d="M12 18v4"/><path d="m4.9 19.1 2.9-2.9"/><path d="M2 12h4"/><path d="m4.9 4.9 2.9 2.9"/></svg>
                                Pending</span></div>`;

                            case 1:
                                return `<div><span class="${baseClass} bg-blue-100 text-blue-800 dark:bg-blue-500/20 dark:text-blue-400">
                                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-circle-dashed-check preview-icon shrink-0 size-3"><path d="M10.1 2.182a10 10 0 013.8 0"/><path d="M13.9 21.818a10 10 0 01-3.8 0"/><path d="m16 9-5.5 5.5L8 12"/><path d="M17.609 3.721a10 10 0 012.69 2.7"/><path d="M2.182 13.9a10 10 0 010-3.8"/><path d="M20.279 17.609a10 10 0 01-2.7 2.69"/><path d="M21.818 10.1a10 10 0 010 3.8"/><path d="M3.721 6.391a10 10 0 012.7-2.69"/><path d="M6.391 20.279a10 10 0 01-2.69-2.7"/></svg>
                                Ready for Claim</span></div>`;

                            case 2:
                                return `<div><span class="${baseClass} bg-teal-100 text-teal-800 dark:bg-teal-500/20 dark:text-teal-400">
                                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-check-check preview-icon shrink-0 size-3"><path d="M18 6 7 17l-5-5"/><path d="m22 10-7.5 7.5L13 16"/></svg>
                                Claimed</span></div>`;

                            default:
                                return `<div><span class="${baseClass} bg-yellow-100 text-yellow-800 dark:bg-yellow-500/20 dark:text-yellow-400">
                                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-circle-question-mark preview-icon shrink-0 size-3"><circle cx="12" cy="12" r="10"/><path d="M9.09 9a3 3 0 0 1 5.83 1c0 2-3 3-3 3"/><path d="M12 17h.01"/></svg>
                                Unknown</span></div>`;
                        }
                    }
                },
                {
                    data: "readyAt",
                    searchable: false,
                    defaultContent: "N/A",
                    render: DataTable.render.text()
                },
                {
                    data: "claimedAt",
                    searchable: false,
                    defaultContent: "N/A",
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
                <button type="button" hx-sync="#resultOffCanvasContent:replace" hx-get="/Results/ResultDetails" hx-target="#resultOffCanvasContent" hx-swap="innerHTML" hx-disabled-elt="this" class="py-2 px-3 inline-flex items-center gap-x-2 text-sm font-medium rounded-lg bg-blue-100 border border-transparent text-blue-800 hover:bg-blue-200 focus:outline-hidden focus:bg-blue-200 disabled:opacity-50 disabled:pointer-events-none dark:text-blue-400 dark:bg-blue-800/30 dark:hover:bg-blue-500/20 dark:focus:bg-blue-500/20">View</button>`;
                    }
                }
            ],

            columnDefs: [
                {
                    targets: "_all",
                    className: "p-2.5 sm: text-sm text-gray-800 dark:text-neutral-200"
                },
                {
                    targets: 2,
                    className: "font-medium"
                },
                {
                    targets: 7,
                    className: "text-end"
                }
            ]
        });

        const resultsTable = instance.dataTable;

        const statusInput = document.getElementById("resultStatus");
        const fromInput = document.getElementById("resultDateFrom");
        const toInput = document.getElementById("resultDateTo");
        const applyButton = document.getElementById("resultApplyBTN");

        applyButton.addEventListener("click", () =>
        {
            const fromDate = fromInput.value;
            const toDate = toInput.value;

            if (fromDate && toDate && fromDate > toDate)
            {
                alert("Date From must be on or before Date To.");
                return;
            }

            appliedFilters = {
                status: statusInput.value,
                fromDate,
                toDate
            };

            resultsTable.ajax.reload(null, true);
        });

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
