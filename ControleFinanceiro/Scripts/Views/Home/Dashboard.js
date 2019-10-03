let app;
class Dashboard {
    constructor() {
    }

    Mask() {
        $(".valores").mask("000.000,00", { reverse: true });
    }
}

$(document).ready(function () {
    app = new Dashboard();
  })