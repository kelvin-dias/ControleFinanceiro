let app;
class DespesaDia {
    constructor() {
        this.Mask();
    }

    Mask() {
        $(".valores").mask("000.000,00", { reverse: true });
    }
}

$(document).ready(function(){
    app = new DespesaDia();
 });