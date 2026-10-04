(() => {
    if (window.lablinkPatientsInitialized) return;
    window.lablinkPatientsInitialized = true;

    let activeTable = null;
    let searchTimer;
    function initializePatientsTable() {
    const wrapper = document.getElementById("patientsDatatable");
    const searchInput = document.getElementById("patientSearch");

    if (!wrapper || !searchInput || activeTable?.wrapper === wrapper) return;
    const instance = new HSDataTable(wrapper, {
        autoWidth: true,
        processing: true,
        serverSide: true,
        orderMulti: false,
        order: [[0, "asc"]],

        ajax: {
            url: wrapper.dataset.patientsUrl,
            type: "GET"
        },

        columns: [
            {
                data: "name",
                render: DataTable.render.text()
            },
            {
                data: "dob",
                render: DataTable.render.text()
            },
            {
                data: "phoneNumber",
                render: DataTable.render.text()
            },
            {
                data: "smsConsent",
                searchable: false,
                render: (value, type) =>
                {
                    if (type !== "display") return value ? "Yes" : "No"; // keeps sorting/filtering on plain text

                    return value
                        ? ' <span class="inline-flex items-center gap-x-1.5 py-1.5 px-3 rounded-full text-xs font-medium bg-teal-100 text-teal-800 dark:bg-teal-500/20 dark:text-teal-400">Has Consent</span>'
                        : '<span class="inline-flex items-center gap-x-1.5 py-1.5 px-3 rounded-full text-xs font-medium bg-red-100 text-red-800 dark:bg-red-500/20 dark:text-red-400">No Consent</span>';
                }
            },
            {
                data: "consentDate",
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
                <button type="button" data-action="edit" data-id="${row.id}" class="py-2 px-3 inline-flex items-center gap-x-2 text-sm font-medium rounded-lg bg-blue-100 border border-transparent text-blue-800 hover:bg-blue-200 focus:outline-hidden focus:bg-blue-200 disabled:opacity-50 disabled:pointer-events-none dark:text-blue-400 dark:bg-blue-800/30 dark:hover:bg-blue-500/20 dark:focus:bg-blue-500/20">Edit</button>
                <button type="button" data-action="delete" data-id="${row.id}" class="py-2 px-3 inline-flex items-center gap-x-2 text-sm font-medium rounded-lg bg-red-100 border border-transparent text-red-800 hover:bg-red-200 focus:outline-hidden focus:bg-red-200 disabled:opacity-50 disabled:pointer-events-none dark:text-red-500 dark:bg-red-800/30 dark:hover:bg-red-500/20 dark:focus:bg-red-500/20">Delete</button></div>`;
                }
            }
        ],

        columnDefs: [
            {
                targets: "_all",
                className: "p-3 whitespace-nowrap text-sm text-gray-800 dark:text-neutral-200"
            },
            {
                targets: 5,
                className: "text-end"
            }
        ]
    });

    const patientsTable = instance.dataTable;
    activeTable = { wrapper, instance, patientsTable };

    // Preline counts locally loaded rows; server-side paging must use page.info().
    const paging = wrapper.querySelector("[data-hs-datatable-paging]");
    const pageButtons = wrapper.querySelector("[data-patient-paging-pages]");
    const previous = wrapper.querySelector("[data-hs-datatable-paging-prev]");
    const next = wrapper.querySelector("[data-hs-datatable-paging-next]");
    const buttonClasses = JSON.parse(wrapper.getAttribute("data-hs-datatable"))
        .pagingOptions.pageBtnClasses;

    function renderPagination() {
        const { page, pages, start, end, recordsDisplay } = patientsTable.page.info();
        paging.classList.toggle("hidden", pages < 2);
        paging.style.display = pages < 2 ? "none" : "";
        previous.disabled = page === 0 || pages === 0;
        next.disabled = pages === 0 || page >= pages - 1;
        pageButtons.replaceChildren();

        // Keep rendering bounded even when the directory contains many pages.
        const visiblePages = new Set();
        if (pages > 0) {
            visiblePages.add(0);
            visiblePages.add(pages - 1);
            for (let index = Math.max(0, page - 1); index <= Math.min(pages - 1, page + 1); index++) {
                visiblePages.add(index);
            }
        }
        let lastPage = -1;
        for (const index of [...visiblePages].sort((a, b) => a - b)) {
            if (lastPage !== -1 && index - lastPage > 1) {
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
            if (index === page) {
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

    pageButtons.addEventListener("click", event => {
        const button = event.target.closest("button[data-page]");
        if (!button || !pageButtons.contains(button)) return;
        patientsTable.page(Number(button.dataset.page)).draw("page");
    });
    patientsTable.on("draw", renderPagination);
    renderPagination();

    searchInput.addEventListener("input", () =>
    {
        clearTimeout(searchTimer);

        searchTimer = setTimeout(() =>
        {
            patientsTable.search(searchInput.value).draw();
        }, 350);
    });

    }

    htmx.onLoad(initializePatientsTable);
    if (document.readyState === "loading") {
        document.addEventListener("DOMContentLoaded", initializePatientsTable, { once: true });
    } else {
        initializePatientsTable();
    }
    document.addEventListener("dataCreated", () => {
        activeTable?.patientsTable.ajax.reload(null, false);
    });
    document.addEventListener("htmx:beforeCleanupElement", event => {
        if (!activeTable || !event.detail.elt.contains(activeTable.wrapper)) return;
        clearTimeout(searchTimer);
        const { instance } = activeTable;
        activeTable = null;
        instance.destroy();
    });
})();
