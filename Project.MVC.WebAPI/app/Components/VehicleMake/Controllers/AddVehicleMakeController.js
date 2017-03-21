/*routerApp.controller("AddVehicleMakeController", function ($scope, $http, $location, $window) {
    $scope.addVehicleMake=function()
    {
        var vehicle =
            {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };
        $http.post('/api/VehicleMake/Add', vehicle).then(function (data) {

            $scope.response = data;
            $window.alert("Succesfully added!");
            $location.path('/vehicleMake');

        });
    }
});*/