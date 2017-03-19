angular.module('AdminModule', ['ngAnimate', 'ngSanitize', 'ui.bootstrap']);
angular.module('AdminModule').controller('ModalDemoCtrl', function ($uibModal, $log, $document) {
    var $ctrl = this;
    $ctrl.items = ['item1', 'item2', 'item3'];

    $ctrl.animationsEnabled = true;

    $ctrl.open = function (size, parentSelector) {
        var parentElem = parentSelector ?
          angular.element($document[0].querySelector('.modal-demo ' + parentSelector)) : undefined;
        var modalInstance = $uibModal.open({
            animation: $ctrl.animationsEnabled,
            ariaLabelledBy: 'modal-title',
            ariaDescribedBy: 'modal-body',
            templateUrl: 'myModalContent.html',
            windowTemplateUrl : "/content/templates/window.html",
            controller: 'ModalInstanceCtrl',
            controllerAs: '$ctrl',
            size: size,
            appendTo: parentElem,
            resolve: {
                items: function () {
                    return $ctrl.items;
                }
            }
        });

        modalInstance.result.then(function (selectedItem) {
            $ctrl.selected = selectedItem;
        }, function () {
            $log.info('Modal dismissed at: ' + new Date());
        });
    };

    $ctrl.toggleAnimation = function () {
        $ctrl.animationsEnabled = !$ctrl.animationsEnabled;
    };
});

angular.module('AdminModule').controller('ModalInstanceCtrl', function ($uibModalInstance, items) {
    var $ctrl = this;
    $ctrl.items = items;
    $ctrl.selected = {
        item: $ctrl.items[0]
    };

    $ctrl.ok = function () {
        $uibModalInstance.close($ctrl.selected.item);
    };

    $ctrl.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };
});

angular.module("AdminModule")
    .controller("AdminController", function ($scope, $http) {
        $scope.Users = [];
        $scope.Genders = ["Male", "Female", ""];
        $scope.Greetings = ["Mr.", "Mrs.", ""];
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
