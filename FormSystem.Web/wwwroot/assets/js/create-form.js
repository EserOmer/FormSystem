jQuery(function($){
$.fn.ratingThemes['fontawesome5-theme'] = {
        filledStar: '<i class="fas fa-star text-orange-m2"></i>',
        emptyStar: '<i class="far fa-star"></i>',
        clearButton: '<i class="fas fa-minus-circle text-110"></i>'
    };

    $('.star-rating').rating({
        animate: false,
        hoverOnClear: false,
        size: 'sm',
        theme: 'fontawesome5-theme',
        containerClass: 'is-star',

        clearCaptionClass: 'badge badge-sm btn-light-secondary border-1 text-80',

        starCaptionClasses: {
            0.5: 'badge badge-sm btn-light-danger border-1 text-80',
            1: 'badge badge-sm btn-light-danger border-1 text-80',
            1.5: 'badge badge-sm btn-light-danger border-1 text-80',
            2: 'badge badge-sm btn-light-warning border-1 text-80',
            2.5: 'badge badge-sm btn-light-warning border-1 text-80',
            3: 'badge badge-sm btn-light-warning border-1 text-80',
            3.5: 'badge badge-sm btn-light-info border-1 text-80',
            4: 'badge badge-sm btn-light-info border-1 text-80',
            4.5: 'badge badge-sm btn-light-success border-1 text-80',
            5: 'badge badge-sm badge-success text-80'
        }
    });	
}