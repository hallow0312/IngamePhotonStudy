namespace UltimateCartFights.Network
{
    public class NoneState : INetworkState
    {
        public void Start() { }   
        public void Terminate() { }
        public void Update() { }
    }
    public class CloseState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class LoadingLobbyState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class LobbyState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class RoomState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class LoadingGameState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class GameState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
    public class ResultState : INetworkState
    {
        public void Start() { }
        public void Terminate() { }
        public void Update() { }
    }
}