(function ($) {
    "use strict";

    // Spinner
    var spinner = function () {
        setTimeout(function () {
            if ($('#spinner').length > 0) {
                $('#spinner').removeClass('show');
            }
        }, 1);
    };
    spinner();
    
    
    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 300) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });


    // Sidebar Toggler
    $('.sidebar-toggler').click(function () {
        $('.sidebar, .content').toggleClass("open");
        return false;
    });


    // Progress Bar
    $('.pg-bar').waypoint(function () {
        $('.progress .progress-bar').each(function () {
            $(this).css("width", $(this).attr("aria-valuenow") + '%');
        });
    }, {offset: '80%'});


    // Calender
    $('#calender').datetimepicker({
        inline: true,
        format: 'L'
    });


    // Testimonials carousel
    $(".testimonial-carousel").owlCarousel({
        autoplay: true,
        smartSpeed: 1000,
        items: 1,
        dots: true,
        loop: true,
        nav : false
    });


    // Chart Global Color
    Chart.defaults.color = "#6C7293";
    Chart.defaults.borderColor = "#000000";


    // Doughnut Chart
    $(".canvas").each((index, value) => {
        value.innerHTML = '<div class="show d-flex align-items-center justify-content-center w-100" > <div class="spinner-border text-primary text-center" style = "width: 3rem; height: 3rem;" role = "status" > <span class="sr-only" > Loading...</span></div > </div>';

    })

    $.get("https://localhost:7191/ilanlar/getcountofilanlar", (data, status) => {
        if (status == "success") {

            var countsOfIlanlar = JSON.parse(data);

            var ctx6 = $("#doughnut-chart").get(0).getContext("2d");
            var myChart6 = new Chart(ctx6, {
                type: "doughnut",
                data: {
                    labels: ["Arsa", "Tarla", "Dukkan", "Depo", "Daire"],
                    datasets: [{
                        backgroundColor: [
                            "rgba(76, 185, 231, .7)",
                            "rgba(76, 185, 231, .6)",
                            "rgba(76, 185, 231, .5)",
                            "rgba(76, 185, 231, .4)",
                            "rgba(76, 185, 231, .3)"
                        ],
                        data: [countsOfIlanlar.CountOfArsa,
                        countsOfIlanlar.CountOfTarla,
                        countsOfIlanlar.CountOfDukkan,
                        countsOfIlanlar.CountOfDepo,
                        countsOfIlanlar.CountOfDaire]
                    }]
                },
                options: {
                    responsive: true
                }
            });
        }
    });

    $.get("https://localhost:7191/ilanlar/getsatilikkiralik", (data, status) => {
        if(status == "success") {
            var countsOfSatilikKiralik = JSON.parse(data);

            var ctx7 = $("#doughnut-chart2").get(0).getContext("2d");
            var myChart7 = new Chart(ctx7, {
                type: "doughnut",
                data: {
                    labels: ["Satilik", "Kiralik"],
                    datasets: [{
                        backgroundColor: [
                            "rgba(76, 185, 231, .7)",
                            "rgba(76, 185, 231, .3)"
                        ],
                        data: [countsOfSatilikKiralik.Satilik, countsOfSatilikKiralik.Kiralik]
                    }]
                },
                options: {
                    responsive: true
                }
            });
        }
    });

    $.get("https://localhost:7191/talepler/getcountoftalepler", (data, status) => {
        if (status == "success") {

            var countsOfTalepler = JSON.parse(data);

            var ctx8 = $("#doughnut-chart3").get(0).getContext("2d");
            var myChart8 = new Chart(ctx8, {
                type: "doughnut",
                data: {
                    labels: ["Arsa", "Tarla", "Dukkan", "Depo", "Daire"],
                    datasets: [{
                        backgroundColor: [
                            "rgba(76, 185, 231, .7)",
                            "rgba(76, 185, 231, .6)",
                            "rgba(76, 185, 231, .5)",
                            "rgba(76, 185, 231, .4)",
                            "rgba(76, 185, 231, .3)"
                        ],
                        data: [countsOfTalepler.CountOfArsa,
                        countsOfTalepler.CountOfTarla,
                        countsOfTalepler.CountOfDukkan,
                        countsOfTalepler.CountOfDepo,
                        countsOfTalepler.CountOfDaire]
                    }]
                },
                options: {
                    responsive: true
                }
            });
        }
    });
    
    $.get("https://localhost:7191/talepler/getsatilikkiralik", (data, status) => {
        if (status == "success") {

            var countsOfSatilikKiralik = JSON.parse(data);

            var ctx9 = $("#doughnut-chart4").get(0).getContext("2d");
            var myChart9 = new Chart(ctx9, {
                type: "doughnut",
                data: {
                    labels: ["Satilik", "Kiralik"],
                    datasets: [{
                        backgroundColor: [
                            "rgba(76, 185, 231, .7)",
                            "rgba(76, 185, 231, .3)"
                        ],
                        data: [countsOfSatilikKiralik.Satilik, countsOfSatilikKiralik.Kiralik]
                    }]
                },
                options: {
                    responsive: true
                }
            });
        }
    });
    

    
})(jQuery);