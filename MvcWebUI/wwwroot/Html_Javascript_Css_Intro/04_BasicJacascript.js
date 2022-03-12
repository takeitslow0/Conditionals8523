function ucgenDoldur(tersten = false) {
    var sonuc;
    /*var sonucArray = []*/
    var sonucArray = new Array();
    for (var i = 0; i < 5; i++) {
        sonuc = "";
        for (var j = 0; j <= i; j++) {
            sonuc += "*";
        }
        sonucArray[i] = sonuc;
    }
    sonuc = "";
    if (!tersten) {
        for (var i = 0; i < sonucArray.length; i++) {
            sonuc += sonucArray[i] + "\n";
        }
    }
    else {
        for (var i = sonucArray.length - 1; i >= 0; i--) {
            sonuc += sonucArray[i] + "\n";
        }
    }
    //console.log(sonuc);
    return sonuc;
}

function onLoadIleDoldur() {
    var mytextarea = document.getElementById("mytextareaid");
    mytextarea.value = ucgenDoldur();
}

var terstenGlobal = true;

function onClickIleDoldur() {
    var mytextarea = document.getElementById("mytextareaid");
    mytextarea.value = ucgenDoldur(terstenGlobal);
    var body = document.getElementsByTagName("body")[0];
    if (terstenGlobal)
        body.style.backgroundColor = "blue";
    else
        body.style.backgroundColor = "yellow";
    terstenGlobal = !terstenGlobal;
}