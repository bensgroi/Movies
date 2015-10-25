angular.module("moviesDB", ["ngRoute", "moviesDB.movies.controllers"])
    .config(["$routeProvider", "$locationProvider",
        ($routeProvider: angular.route.IRouteProvider, $locationProvider: angular.ILocationProvider) => {
            $routeProvider
                .when("/movies", {
                    controller: "MoviesListController",
                    controllerAs: "ctrl",
                    templateUrl: "/app/movies/list.html"
                })

                .otherwise({
                    controller: "MoviesListController",
                    controllerAs: "ctrl",
                    templateUrl: "/app/movies/list.html"
                });


            $locationProvider.html5Mode(true);
        }
    ]);