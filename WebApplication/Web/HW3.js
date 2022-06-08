var audio = document.getElementById("music");//在這份文件document取得這個文件getElementById，丟到audio
var btnPlay = document.getElementById("btnPlay");
var volValue = document.getElementById("volValue");
var volinfo = document.getElementById("volinfo");
var info = document.getElementById("info");
var song = document.getElementById("song");
var progress = document.getElementById("progress");
var book = document.getElementById("book");
//console.log(audio.children[0].title);
//book.parentNode
song.addEventListener('change', function () {
    changeMusic(song.selectedIndex);
});
var option;
var tBook = book.children[1];
//更新上面下拉式選單歌單
function UpdateMusic() {
    //移除目前下拉選單的所有歌曲
    for (var j = song.children.length - 1; j >= 0; j--) {
        song.removeChild(song.children[j]);
    }
    //再抓我的歌本中的歌曲
    for (var i = 0; i < tBook.children.length; i++) {
        option = document.createElement("option");//<option></option>
        option.innerText = tBook.children[i].innerText;
        option.value = tBook.children[i].title;
        song.appendChild(option);
    }
    changeMusic(0);
}
    //歌本拖拉區
    function allowDrop(ev) {
        ev.preventDefault();//停止物件預設行為
    }
    function drag(ev) {
        ev.dataTransfer.setData("IamAGoodBoy", ev.target.id);
    }
    function drop(ev) {
        ev.preventDefault();
        var data = ev.dataTransfer.getData("IamAGoodBoy");
        if (ev.target.id == "")
            ev.target.appendChild(document.getElementById(data));
        else
            ev.target.parentNode.appendChild(document.getElementById(data));
    }
    
    //console.log(sBook.children.length);
    var option;
    var sBook = book.children[0];    
    for (var i = 0; i < sBook.children.length; i++) {
        sBook.children[i].draggable = "true";
        sBook.children[i].id = "song" + (i + 1);
        sBook.children[i].addEventListener('dragstart', function () {
            drag(event);
        });
        option = document.createElement("option");//<option></option>
        option.innerText = sBook.children[i].innerText;
        option.value = sBook.children[i].title;
        song.appendChild(option);

    }
    changeMusic(0);
    function songBook() {
        book.className = book.className == "" ? "hide" : "";
    }
    //全部循環

    function setAllLoop() {
        info.children[2].innerText = info.children[2].innerText == "全部循環" ? "狀態" : "全部循環";
        //audio.loop = !audio.loop;
    }

    //隨機撥放，有放回的機率
    function setRandom() {
        //var n = Math.floor(Math.random() * song.options.length);
        info.children[2].innerText = info.children[2].innerText == "隨機撥放" ? "狀態" : "隨機撥放";

    }

    //單曲循環
    function setLoop() {
        info.children[2].innerText = info.children[2].innerText == "單曲循環" ? "狀態" : "單曲循環";
        //audio.loop = !audio.loop;
    }

    //靜音
    function setMuted() {
        audio.muted = !audio.muted;
    }


    //時間軸
    function setTimeBar() {
        audio.currentTime = progress.value;
    }

    //上一首下一首(小麥版)
function changeSong(i) {
    var index = (song.selectedIndex + i) % song.options.length;
    var realIndex = index >= 0 ? index : song.options.length + index
    changeMusic(realIndex);
}

//上一首下一首(原版.已壞)
//function changeSong(i) {
//    var index = song.selectedIndex + i;
//    if (index < song.options.length - 1) {
//        changeMusic(index);
//    } else {
//        changeMusic(0);
//    }

//}

    //歌曲切換
    var musicObj, musicIndex = 0;
    function changeMusic(i) {//這裡是參數。也可以用id=select1寫，就要配getelement
        //console.log(evt)看consol可以看到有一個target選項
        //console.log(evt.target.options[evt.target.selectedIndex].value);
        //musicObj = evt.target.options;
        //evt(事件的物件，例如人事資料表)這個物件有一個屬性叫target，這個target要對option做動作。動作看成一個東西，在這裡是下拉式選單從A選到b
        //musicIndex = evt.target.selectedIndex;

        song.options[i].selected = true;

        //if (song.options[i] < 0)
        //    song.options[0];
        //Play();

        audio.children[0].src = song.options[i].value;
        audio.children[0].title = song.options[i].innerText;
        audio.load();

        if (btnPlay.innerText == ";")
            Play();

    }


    //時間格式轉換
    var min = 0, sec = 0, min2 = 0, sec2 = 0;
    function getTimeFormat(time) {
        min = parseInt(time / 60);
        sec = parseInt(time % 60);
        //if (min < 10)
        //    min = "0" + min;
        //if (sec < 10)
        //    sec = "0" + sec;
        min = min < 10 ? "0" + min : min;
        sec = sec < 10 ? "0" + sec : sec;
        return min + ":" + sec;
    }


    //取得歌曲播放時間

    function getDuration() {
        progress.max = parseInt(audio.duration);
        progress.value = parseInt(audio.currentTime);

        var w = (audio.currentTime / audio.duration * 100) + "%";
        progress.style.backgroundImage = "-webkit-linear-gradient(left,#b60000,#b60000 " + w + ", #c8c8c8 " + w + ",#c8c8c8)";

        info.children[1].innerText = getTimeFormat(audio.currentTime) + "     /    " + getTimeFormat(audio.duration);
        setTimeout(getDuration, 10);
        if (audio.currentTime == audio.duration) {
            if (info.children[2].innerText == "隨機撥放") {
                var n = Math.floor(Math.random() * song.options.length);
                changeMusic(n);
            }
            else if (info.children[2].innerText == "全部循環" && song.selectedIndex == song.options.length - 1) {
                changeMusic(0);
            }
            else if (info.children[2].innerText == "單曲循環") {
                //changeMusic(song.selectedIndex);
                changeSong(0);
            }
            else if (song.selectedIndex == song.options.length - 1) {
                Stop();
            }
            else
                changeSong(1);
        }
    }

    //撥放與暫停功能
    function Play() {
        if (audio.paused) {
            audio.play();
            btnPlay.innerText = ";";
            info.children[0].innerText =  audio.children[0].title + "playing";
            getDuration();
            console.log(audio.children[0].title);
        }
        else {
            audio.pause();
            btnPlay.innerText = "4";
            info.children[0].innerText = "暫停中"
        }

    }
    //停止撥放功能
    function Stop() {
        audio.pause();
        audio.currentTime = 0;
        btnPlay.innerText = "4";
        info.children[0].innerText = "停止"
    }
    //function Pause() {
    //    audio.pause();
    //}
    //function foreTime() {
    //    audio.pause();
    //    audio.currentTime += 5;
    //}
    //function bakeTime() {
    //    audio.pause();
    //    audio.currentTime -= 5;
    //}
    //快轉/倒轉功能
    function changeTime(t) {  //將快進後退合併成一個功能，只改參數
        audio.currentTime += t;
    }
    //音量微調
    function changeVolume(v) {
        //audio.volume += v;
        volValue.value = parseInt(volValue.value) + v;
        setVolume();
    }
    //音量調整
/*    setVolume()*/
//setVolume()
function setVolume() {
    console.log(volValue.value)
    volinfo.value = volValue.value;
    console.log(volinfo);
    audio.volume = parseInt(volValue.value) / 100;
    console.log(audio.volume);
    var z = volValue.value + "%";
    console.log(z);
    volValue.style.backgroundImage = "-webkit-linear-gradient(left,#009d72,#009d72 " + z + ", #c8c8c8 " + z + ",#c8c8c8)";

}