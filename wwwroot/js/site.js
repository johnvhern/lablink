// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

htmx.onLoad(function ()
{
    window.HSStaticMethods.autoInit();
});

function showToast(message, type = "success")
{
    const content = document.createElement("div");

    content.innerHTML = `
        <div class="flex gap-x-3 p-4">
            <span data-icon class="shrink-0 font-semibold"
                  aria-hidden="true"></span>

            <p data-message class="grow text-sm text-sm text-gray-800 dark:text-white"></p>

            <button data-close type="button"
                    class="inline-flex shrink-0 justify-center items-center
                           size-5 rounded-lg text-muted-foreground-1 opacity-50
                           hover:opacity-100 focus:outline-hidden focus:opacity-100 dark:text-muted-foreground-1"
                    aria-label="Close">
                <svg class="shrink-0 size-4"
                     xmlns="http://www.w3.org/2000/svg"
                     width="24" height="24" viewBox="0 0 24 24"
                     fill="none" stroke="currentColor" stroke-width="2"
                     stroke-linecap="round" stroke-linejoin="round">
                    <path d="M18 6 6 18"></path>
                    <path d="m6 6 12 12"></path>
                </svg>
            </button>
        </div>
    `;

    // Insert dynamic messages as plain text.
    content.querySelector("[data-message]").textContent = message;

    const icon = content.querySelector("[data-icon]");
    icon.textContent = type === "error" ? "!" : "✓";
    icon.classList.add(
        type === "error" ? "text-red-500" : "text-teal-500"
    );

    const toast = Toastify({
        node: content,
        className: "hs-toastify-on:opacity-100 opacity-0 fixed -bottom-20 sm:-bottom-37.5 inset-e-0 sm:inset-e-5 z-90 transition-all duration-300 w-80 bg-white dark:bg-neutral-800 border border-gray-200 dark:border-neutral-700 rounded-xl shadow-lg [&>.toast-close]:hidden",
        duration: 4000,
        close: false,
        gravity: "bottom",
        position: "right",
        ariaLive: type === "error" ? "assertive" : "polite"
    });

    content.querySelector("[data-close]").addEventListener("click", () =>
    {
        toast.hideToast();
    });

    toast.showToast();
}

document.addEventListener("showToast", function (event)
{
    showToast(event.detail.message, event.detail.type);
});

document.addEventListener("dataCreated", function ()
{
    window.HSOverlay.close("#crudModal");
});