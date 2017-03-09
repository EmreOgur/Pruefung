var adminModule = angular.module("AdminModule", [])
    .controller("AdminController", function ($scope, $http) {
        $scope.Users = [];
        $scope.Genders = ["Male", "Female",""];
        $scope.Greetings=["Mr.", "Mrs.",""];
        $scope.Count = 0;
        $scope.newUser = {};

        $scope.submit = function () {

            var gg = myForm.$valid;
            $scope.Count = $scope.Count + 1;
            $scope.newUser.ID = $scope.Count;
            $scope.Users.push($.extend({}, $scope.newUser));
            document.getElementById("myForm").reset();
            
        };
        $scope.Edit = function (user) {
            $scope.newUser = angular.copy(user);
        };
        $scope.Update = function (user) {
            $scope.newUser = angular.copy(user);
        };
    });