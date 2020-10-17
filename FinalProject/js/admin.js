var saveEdit;
$(document).ready(function () {
    // Activate tooltip

    $('[data-toggle="tooltip"]').tooltip();

    // Select/Deselect checkboxes
    var checkbox = $('table tbody input[type="checkbox"]');
    $("#selectAll").click(function () {
        if (this.checked) {
            checkbox.each(function () {
                this.checked = true;
            });
        } else {
            checkbox.each(function () {
                this.checked = false;
            });
        }
    });
    checkbox.click(function () {
        if (!this.checked) {
            $("#selectAll").prop("checked", false);
        }
    });
});

//https://www.cssscript.com/minimal-notification-popup-pure-javascript/
$(document).on('click', '.editWithPic', function () {
    saveEdit = $(this);

})

$(document).on('click', '#submitEdit', function () {
    saveEdit = $(this);
    var fileInput = document.getElementById('fileInput');

    var trade = document.getElementById('tradeId');
    var manu = document.getElementById('manuId');
    var gen = document.getElementById('genId');
    var active = document.getElementById('actId');
    var portion = document.getElementById('portId');


    var form = new FormData();
    form.append("", fileInput.files[0], "/D:/aaa.png");

    var settings = {
        "url": "http://localhost:52755/Home/edit",
        "method": "POST",
        "timeout": 0,
        "processData": false,
        "mimeType": "multipart/form-data",
        "contentType": false,
        "headers": {
            "trade": trade.value,
            "active": active.value
        },
        "data": form,
        async: false
    };

    $.ajax(settings).done(function (response) {
        //if (response == false)
        if (response.toLowerCase() == 'true') {
            window.createNotification({
                closeOnClick: true,
                displayCloseButton: false,
                positionClass: 'ncf-top-right',
                showDuration: 9000,
                theme: 'success'
            })({
                title: 'Success',
                message: 'Picture was successfully uploaded'
            });
        } else {
            window.createNotification({
                closeOnClick: true,
                displayCloseButton: false,
                positionClass: 'ncf-top-right',
                showDuration: 9000,
                theme: 'warning'
            })({
                title: 'Warning',
                message: 'Image is not a real medicine'
            });
        }
    });
})

function upload() {
    var trade = document.getElementById('tradeId');
    var manu = document.getElementById('manuId');
    var gen = document.getElementById('genId');
    var active = document.getElementById('actId');
    var portion = document.getElementById('portId');
    //var body = { trade=trade, manu=manu, gen=gen, active=active, portion=portion };
    //var json = JSON.stringify(body);
    //var blob = new Blob([json],
    //    { type: "application/json" });

    var fileInput = document.getElementById('uploadSubmit');
    var form = new FormData();
    form.append("", fileInput.files[0], "/D:/aaa.png");
    //form.append("details", blob);
    var settings = {
        "url": "http://localhost:52755/Home/create",
        "method": "POST",
        "timeout": 0,
        "processData": false,
        "mimeType": "multipart/form-data",
        "contentType": false,
        "data": form,
        "headers": {
            "trade": trade.value,
            "active":active.value
        },
        async: false
    };

    $.ajax(settings).done(function (response) {
        if (response.toLowerCase() == 'true') {
            window.createNotification({
                closeOnClick: true,
                displayCloseButton: false,
                positionClass: 'ncf-top-right',
                showDuration: 9000,
                theme: 'success'
            })({
                title: 'Success',
                message: 'Picture was successfully uploaded'
            });
        } else {
            window.createNotification({
                closeOnClick: true,
                displayCloseButton: false,
                positionClass: 'ncf-top-right',
                showDuration: 9000,
                theme: 'warning'
            })({
                title: 'Warning',
                message: 'Image is not a real medicine'
            });
        }
    });
}

