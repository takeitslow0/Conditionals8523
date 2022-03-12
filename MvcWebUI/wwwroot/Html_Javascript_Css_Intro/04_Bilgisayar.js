function bilgisayarOlustur() {
    var marka = document.getElementById("marka");
    var model = document.getElementById("model");
    var hiz = document.getElementById("hiz");
    var hafiza = document.getElementById("hafiza");
    var susogutma = document.getElementById("susogutma");
    var uretimtarihi = document.getElementById("uretimtarihi");
    let bilgisayar = new Bilgisayar(
        marka.value,
        model.value,
        parseFloat(hiz.value),
        parseInt(hafiza.value),
        susogutma.checked,
        new Date(uretimtarihi.value + " 00:00:00")
    );
    var p = document.getElementById("bilgisayar");
    p.innerHTML = bilgisayar.getir();
}

class Bilgisayar {
    constructor(marka, model, hiz, hafiza, susogutma, uretimtarihi) {
        this.marka = marka;
        this.model = model;
        this.hiz = hiz;
        this.hafiza = hafiza;
        this.susogutma = susogutma;
        this.uretimtarihi = uretimtarihi;
    }

    getir() {

        return '<b><i>Marka:</i></b> ' + this.marka + '<br />' +
            '<b><i>Model:</i></b> ' + this.model + '<br />' +
            '<b><i>İşlemci Hızı:</i></b> ' + this.hiz + ' GHz<br />' +
            '<b><i>Hafıza:</i></b> ' + this.hafiza + ' GB<br />' +
            '<b><i>Su Soğutma:</i></b> ' + (this.susogutma ? 'Evet' : 'Hayır') + '<br />' +
            '<b><i>Üretim Tarihi:</i></b> ' + this.uretimtarihi.toLocalString('tr-TR');
    }
}