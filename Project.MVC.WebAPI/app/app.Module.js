var routerApp = angular.module('routerApp', ['ui.router', 'angularUtils.directives.dirPagination']);//kolekcije kontrolera, modela, servisa.

routerApp.config(function($stateProvider, $urlRouterProvider)//.otherwise-default route
{
    $urlRouterProvider.otherwise('/vehicleMake');

    $stateProvider.state('vehicleMake', {//ui-sref=VhicleMake-->the name of state that we want to refer
        url: '/vehicleMake',//URL that we want to navigate to--when click on VehicleMake we activate this
        controller: 'VehicleMakeController',//controller iz kojeg uzima?
        views: {
            "root": {
                templateUrl: 'app/Components/VehicleMake/Views/IndexVehMake.html'
            }
        }
    }).state('vehicleMakeAdd', {
        url: '/vehicleMakeAdd',
        controller: 'VehicleMakeAddController',
        views: {
            "root": {
                templateUrl: 'app/Components/VehicleMake/Views/VehicleMakeAdd.html'
            }
        }
    })

    ;})