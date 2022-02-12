﻿$(document).ready(function () {
    //Slangs
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
            $('#slang-upload-file').val("");
        } else {
            $('#warningMessage').hide();
        }
    });
    //Abbreviations
    $('#abbrev-upload-file').on('change', function () {
        console.log("I am inside upload event");
        files = $(this)[0].files;
        name = '';
        for (var i = 0; i < files.length; i++) {
            name += '\"' + files[i].name + '\"' + (i != files.length - 1 ? ", " : "");
        }
        $(".custom-file-label").html(name);
    });
    $('#abbrev-upload-file').change(function () {
        var fileExtension = ['csv', 'xlsx'];
        if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
            $('#warningMessage').show();
            $('#abbrev-upload-file').val("");
        } else {
            $('#warningMessage').hide();
        }
    });
    //Corpus words
    $('#corpus-record-file').on('change', function () {
        console.log("I am inside upload event");
        files = $(this)[0].files;
        name = '';
        for (var i = 0; i < files.length; i++) {
            name += '\"' + files[i].name + '\"' + (i != files.length - 1 ? ", " : "");
        }
        $(".custom-file-label").html(name);
    });
    $('#corpus-record-file').change(function () {
        var fileExtension = ['txt'];
        if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
            $('#warningMessage').show();
            $('#abbrev-upload-file').val("");
        } else {
            $('#warningMessage').hide();
        }
    });
    displaySwalSuccessUpload = function (message) {
        Swal.fire(
            message,
            'You have successfully uploaded file',
            'success'
        )
    }
});