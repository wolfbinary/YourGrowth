class ExerciseRoutinesUI {
    static initializeTab() {
        $("#adminExerciesToUse, #adminExercisesUsed").sortable({
            connectWith: ".connectedSortable"
        }).disableSelection();
    }
}