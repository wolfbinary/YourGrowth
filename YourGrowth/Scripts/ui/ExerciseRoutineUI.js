var ExerciseRoutinesUI = (function () {
    function ExerciseRoutinesUI() {
    }
    ExerciseRoutinesUI.initializeTab = function () {
        $("#adminExerciesToUse, #adminExercisesUsed").sortable({
            connectWith: ".connectedSortable"
        }).disableSelection();
    };
    return ExerciseRoutinesUI;
})();
