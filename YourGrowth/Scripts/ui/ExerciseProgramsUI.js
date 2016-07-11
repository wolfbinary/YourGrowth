/// <reference path="../typings/jquery/jquery.d.ts" />
var ExerciseProgramsUI = (function () {
    function ExerciseProgramsUI() {
    }
    ExerciseProgramsUI.initializeTab = function () {
        $("#adminRoutinesToUse, #adminRoutinesUsed").sortable({
            connectWith: ".connectedSortable"
        }).disableSelection();
    };
    return ExerciseProgramsUI;
})();
