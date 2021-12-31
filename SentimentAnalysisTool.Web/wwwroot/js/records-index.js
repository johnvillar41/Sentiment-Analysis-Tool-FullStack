$(document).ready(function () {
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
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Cannot connect to server! Please try again later..',
        });
    }
    promptHasNetwork = function (response) {
        Swal.fire({
            icon: 'success',
            title: 'Succesfull!',
            text: 'Successfully loaded data!',
        });
    }

    renderReviewClassification = function (response) {
        const ctx = document.getElementById('myChart').getContext('2d');
        const myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: ['Positive', 'Negative'],
                datasets: [{
                    label: 'Review Classification',
                    data: [response.reviewClassification.positivePercent, response.reviewClassification.negativePercent],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                    ],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    }

    renderSentimentOverTime = function (response) {
        const ctx = document.getElementById('myChart').getContext('2d');
        const myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: ['Positive', 'Negative'],
                datasets: [{
                    label: 'Review Classification',
                    data: [response.reviewClassification.positivePercent, response.reviewClassification.negativePercent],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                    ],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    }

    promptSuccess = function(response) {
        $("#btnAccuracyProcess").prop("disabled", false);
        $("#btnConfusionMatrixAlgo").prop("disabled", false);
        $("#formFileSubmit").prop("disabled", false);
        console.log(response.textProcessingConfusionMatrix);
        $("#btnAccuracyProcess").on("click", function () {
            Swal.fire({
                title: '<strong>Textprocessing Accuracy</strong>',
                icon: 'info',
                html: `<table class="table">
                            <thead>
                                <tr>
                                    <th>Accuracy</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>${response.textProcessingAccuracy}</td>
                                </tr>
                            </tbody>
                        </table>`,
                showCloseButton: true,
                showCancelButton: true,
                focusConfirm: false,
                confirmButtonText:
                    '<i class="fa fa-thumbs-up"></i> Great!',
                confirmButtonAriaLabel: 'Thumbs up, great!',
                cancelButtonText:
                    '<i class="fa fa-thumbs-down"></i>',
                cancelButtonAriaLabel: 'Thumbs down'
            });
        });
        $("#btnConfusionMatrixAlgo").on("click", function () {
            Swal.fire({
                title: '<strong>Confusion Matrix</strong>',
                icon: 'info',
                html:
                    `<table class="table">
                        <thead>
                            <tr>
                                <th>Accuracy</th>
                                <th>Precision</th>
                                <th>Recall</th>
                                <th>F1 Score</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>${response.algorithmnConfusionMatrix}</td>
                                <td>${response.algorithmnConfusionMatrix}</td>
                                <td>${response.algorithmnConfusionMatrix}</td>
                                <td>${response.algorithmnConfusionMatrix}</td>
                            </tr>
                        </tbody>
                </table>`,
                showCloseButton: true,
                showCancelButton: true,
                focusConfirm: false,
                confirmButtonText:
                    '<i class="fa fa-thumbs-up"></i> Great!',
                confirmButtonAriaLabel: 'Thumbs up, great!',
                cancelButtonText:
                    '<i class="fa fa-thumbs-down"></i>',
                cancelButtonAriaLabel: 'Thumbs down'
            });
        });
    }

    $("#drop-down-env").on("click", function () {
        document.getElementById("corpus-type").value = "EnvironmentReview";
    });
    $("#drop-down-film").on("click", function () {
        document.getElementById("corpus-type").value = "FilmReview";
    });
    $("#drop-down-prod").on("click", function () {
        document.getElementById("corpus-type").value = "ProductReview";
    });

});



