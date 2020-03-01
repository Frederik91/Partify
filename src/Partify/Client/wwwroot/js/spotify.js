let instance;
let isReady = false;
let allowInitialize = true;
let spotifyToken;

window.onSpotifyWebPlaybackSDKReady = () => {
    isReady = true;
    if (allowInitialize) {
        initializePlayer(spotifyToken);
    }
};

function initializePlayer(token) {
    if (!isReady) {
        allowInitialize = true;
        spotifyToken = token;
        return;
    }
    console.log('Creating player with token: ' + spotifyToken);
    const player = new Spotify.Player({
        name: 'Partify',
        getOAuthToken: cb => { cb(spotifyToken); }
    });

    // Error handling
    player.addListener('initialization_error', ({ message }) => { console.error(message); });
    player.addListener('authentication_error', ({ message }) => { console.error(message); });
    player.addListener('account_error', ({ message }) => { console.error(message); });
    player.addListener('playback_error', ({ message }) => { console.error(message); });

    // Playback status updates
    player.addListener('player_state_changed', state => { console.log(state); onPlayerStateChanged(state); });

    // Ready
    player.addListener('ready', ({ device_id }) => {
        console.log('Ready with Device ID', device_id);
    });

    // Not Ready
    player.addListener('not_ready', ({ device_id }) => {
        console.log('Device ID has gone offline', device_id);
    });

    // Connect to the player!
    player.connect();
}

function onPlayerStateChanged(state) {
    instance.invokeMethodAsync('OnPlayerStateChanged', state).then(result => {
    });
}

function registerInstance(dotnetInstance) {
    console.log('Instance created');
    instance = dotnetInstance;
}