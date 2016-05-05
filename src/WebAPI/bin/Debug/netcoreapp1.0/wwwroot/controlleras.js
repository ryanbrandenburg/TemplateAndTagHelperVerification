(function () {
    'use strict';

    angular
        .module('app')
        .controller('controlleras', controlleras);

    controlleras.$inject = ['$location']; 

    function controlleras($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'controlleras';

        activate();

        function activate() { }
    }
})();
