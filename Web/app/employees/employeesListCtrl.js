(function () {
    "use strict";
    angular
        .module("employeeManagement")
        .controller("employeesListCtrl",
                    ["employeeResource",
                        EmployeesListCtrl]);

    function EmployeesListCtrl(employeeResource) {
        var vm = this;

        employeeResource.query(function (data) {
            vm.employees = data
        });
    }
}());
