// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function GetModal() {
    return "<!-- Button trigger modal --> \
            <button type='button' style='display:none' class='btn btn-primary' data-bs-toggle='modal' data-bs-target='#modalCenter' id='modalAlert'></button> \
            <!-- Modal --> \
            <div class='modal fade' id='modalCenter' tabindex='-1' aria-hidden='true'> \
            <div class='modal-dialog modal-dialog-centered' role='document'> \
                <div class='modal-content'> \
                <div class='modal-header'> \
                    <h5 class='modal-title' id='modalCenterTitle'>TITLE_MODAL</h5> \
                    <button type='button'  class='btn-close' id='btnFechar' data-bs-dismiss='modal' aria-label='Close'></button> \
                </div> \
                <div class='modal-body' style='padding:0 !important'> \
                    <div class='row'> \
                    <div class='col mb-3' style='text-align:center'> \
                    </div> \
                    </div> \
                <div style='text-align:center'><label>MSG_ALERT</label></div> \
                <br > \
                <div class='modal-footer' style='justify-content:center' > \
                    <button type='button' data-bs-dismiss='modal' class='btn btn-primary'>OK</button> \
                </div> \
                </div> \
            </div> \
            </div> \
        </div>";
}


function addSuccess(success) {
    if (success != null && success != "") {
        $("button[id='btnFechar']").click();
        $('#alertsModal').html("");
        var modal = GetModal().replace("TITLE_MODAL", "Atenção!");
        modal = modal.replace("MSG_ALERT", success);

        $('#alertsModal').html(modal);
        $('#modalAlert').click();
        $('html, body').scrollTop(0);
    }
}

function addError(error) {
    if (error != null && error != "") {
        $("button[id='btnFechar']").click();
        $('#alertsModal').html("");
        var modal = GetModal().replace("TITLE_MODAL", "Atenção!");
        modal = modal.replace("MSG_ALERT", error);


        $('#alertsModal').html(modal);
        $('#modalAlert').click();
        $('html, body').scrollTop(0);
    }
}

