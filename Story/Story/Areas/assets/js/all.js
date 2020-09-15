$(document).on('ready', function () {
    // slide//
    $(".autoplay").slick({
        infinite: true,
        variableWidth: true,
        slidesToShow: 3,
        autoplay: true,
        autoplaySpeed: 2800,
    });
    $(".dropdown-first").click(
        function () {
            $('.dropdown-first').toggleClass('dropup');
            $('.dropdown-menu-first').css('transform', 'translateY(-10px)').toggleClass('active');
            $('.dropdown-menu-first.active').css('transform', 'translateY(0px)');
            $('.section').css('margin-top', '0px').toggleClass('active');
            $('.section.active').css('margin-top', $(".drop").height() + 'px');
        }
    );
    // End
    // Navbar
    $(".btn-search-nav").click(
        function () {
            $('.btn-search-nav').toggleClass('active').html(
                '<i class="fas fa-search" style="font-size:24px;"></i>'
            );
            $('.btn-search-nav.active').html(
                '<i class="fa fa-times" style="font-size:24px;padding-right:4px;"></i>'
            );
            $('.form-search-nav').toggleClass('active');
            $('.form-search-nav.active').css('margin-top', '-30px');
        }
    );
    // End
    // scrollbars
    $(window).scroll(function () {
        var scroll_px = $(this).scrollTop();
        var roll_in;
        if (scroll_px > 100) {
            $('.btn-scroll-bottom').css('opacity', '0');
            $('.btn-scroll-bottom').css('visibility', 'hidden');
            $('.scroll-to-top').css('right', '10px');
        } else {
            $('.btn-scroll-bottom').css('opacity', '1');
            $('.btn-scroll-bottom').css('visibility', 'visible');
            $('.scroll-to-top').css('right', '-40px');
        }
    });
    $('.scroll-to-top').click(function () {
        $('html,body').animate({ scrollTop: 0 }, '100', 'swing');
    });
    // End
});
function btn_detail(id) {
    var detail = ".detailComic-" + id;
    var btn = ".btn-detail-" + id;
    $(detail).css("display", "table-row");
    $(detail + '.active').css("display", "none");
    $(detail).toggleClass('active');
    $(btn).css("transform", "rotate(45deg)");
    $(btn + '.active').css("transform", "rotate(0)");
    $(btn).toggleClass('active');
}

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#imgShow').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#fileBase").change(function () {
    readURL(this);
});