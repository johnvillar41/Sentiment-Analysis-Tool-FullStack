$('#customfile').on('change', function () {
    console.log("I am inside upload event");
    files = $(this)[0].files;
    name = '';
    for (var i = 0; i < files.length; i++) {
        name += '\"' + files[i].name + '\"' + (i != files.length - 1 ? ", " : "");
    }
    $(".custom-file-label").html(name);
});
$('#customfile').change(function () {
    var fileExtension = ['xlsx', 'csv'];
    if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
        $('#warningMessage').show();
        $('#customfile').val("");
    } else {
        $('#warningMessage').hide();
    }
});

promptNoNetwork = function (response) {
    $('#errorNetwork').show();
}

promptHasNetwork = function (response) {
    $('#errorNetwork').hide();
}