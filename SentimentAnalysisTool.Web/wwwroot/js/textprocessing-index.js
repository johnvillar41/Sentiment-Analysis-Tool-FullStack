$(document).ready(function () {
    $('#slang-upload-file').on('change', function () {
        console.log("I am inside upload event");
        files = $(this)[0].files;
        name = '';
        for (var i = 0; i < files.length; i++) {
            name += '\"' + files[i].name + '\"' + (i != files.length - 1 ? ", " : "");
        }
        $(".custom-file-label").html(name);
    });

    $('#slang-upload-file').change(function () {
        var fileExtension = ['txt'];
        if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
            $('#warningMessage').show();
            $('#customfile').val("");
        } else {
            $('#warningMessage').hide();
        }
    });
});