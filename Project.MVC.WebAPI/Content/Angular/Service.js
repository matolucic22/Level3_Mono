app.service('VehicleService', function ($http) {
    this.getVehicleMake = function () {
        return $http.get('');
    }
});