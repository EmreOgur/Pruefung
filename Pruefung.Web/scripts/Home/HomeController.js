var homeModule = angular.module("HomeModule", [])
    .controller("HomeController", function ($scope, $http) {
        $scope.Messages = [];
        $scope.Person = {
            FirstName: "Sergey",
            LastName: "Marach",
            Salutation: "Mr",
            Gender: "Male"
        };

        var loadMessages = function(){
            $http.get(urls.GetMessages).then(function (resp) {
                $scope.Messages = resp.data;
            });
        };

        loadMessages();

        $scope.SaveMessage = function () {
            $http.post(urls.SaveMessage, JSON.stringify($scope.NewMessage))
            .then(function() { loadMessages(); });
        };
    });