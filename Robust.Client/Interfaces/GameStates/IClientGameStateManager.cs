﻿namespace Robust.Client.Interfaces.GameStates
{
    public interface IClientGameStateManager
    {
        void Initialize();
        void Shutdown();

        void ApplyGameState();
    }
}