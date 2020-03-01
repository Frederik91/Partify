
// 2. This code loads the IFrame Player API code asynchronously.
var tag = document.createElement('script');
tag.id = 'iframe-demo';
tag.src = "https://www.youtube.com/iframe_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

// 3. This function creates an <iframe> (and YouTube player)
//    after the API code downloads.
var player;
function onYouTubeIframeAPIReady() {
    console.log("onYouTubeIframeAPIReady");
    var playerParams =
    {
        playerVars:
        {
            "enablejsapi": 1,
            "origin": document.domain,
            "rel": 0,
            "border-width": "5px",
            "width": 1280,
            "height": 720,
            "videoId": 'M7lc1UVf-VE'
        },
        events:
        {
            "onReady": onPlayerReady,
            "onError": onPlayerError,
            "onStateChange": onPlayerStateChange
        }
    };
    player = new YT.Player("player", playerParams);
    console.log("player created");
}

// 4. The API will call this function when the video player is ready.
function onPlayerReady(event) {
    console.log("onPlayerReady");
}

function onPlayerError(event) {
    console.log(event);
}

// 5. The API calls this function when the player's state changes.
//    The function indicates that when playing a video (state=1),
//    the player should play for six seconds and then stop.
var done = false;
function onPlayerStateChange(event) {
    console.log(event);
}

function stopVideo() {
    player.stopVideo();
}

function loadVideo(videoId) {
    player.loadVideoById(videoId, 0);
}

function pauseVideo() {
    player.pauseVideo();
}
function playVideo() {
    player.playVideo();
}