(function () {
    'use strict';

    angular
        .module('app')
        .controller('controllerwithscope', controllerwithscope);

    controllerwithscope.$inject = ['$scope']; 

    function controllerwithscope($scope) {
        $scope.title = 'controllerwithscope';

        activate();

        function activate() { }
    }
})();
