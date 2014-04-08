angular.module('phonecatFilters', []).filter('checkmark', function () {
    return function (input) {
        return input ? '\u2713' : '\u2718';
    };
}).filter('testFilter', function () {
    return function (input) {
        return input ? 'Hubert' : 'Dumas';
    };
});

