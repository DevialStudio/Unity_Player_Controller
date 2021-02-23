public class PEvent_Idle {
    private PlayerPhysicsController _PhysicsControllerPlayer;
    public PEvent_Idle(PlayerPhysicsController playerPhysicsController) {
        _PhysicsControllerPlayer = playerPhysicsController;
    }

    public void ExecutePhysicsEvent() {
        /**
         * @desc Forces the player's rigidbody to come to a complete stop
        */
        _PhysicsControllerPlayer.FullyStopMotion();
    }
}
