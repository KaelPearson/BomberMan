public static class gameStats {

    private static int playerOneWins = 0;
    public static int PlayerOneWins {
        get {
            return playerOneWins;
        }
        set {
            playerOneWins = value;
        }
    }
    private static int playerTwoWins = 0;
    public static int PlayerTwoWins {
        get {
            return playerTwoWins;
        }
        set {
            playerTwoWins = value;
        }
    }
    private static int game = 0;
    public static int Game {
        get {
            return game;
        } set {
            game = value;
        }
    }
}