public static class Player2Stats {

    private static float movementSpeed = 3;
    public static float MovementSpeed {
        get {
            return movementSpeed;
        }
        set {
            movementSpeed = value;
        }
    }

    private static int bombSize = 5;
    public static int BombSize {
        get {
            return bombSize;
        }
        set {
            bombSize = value;
        }
    }
    private static int bombAvaiable = 8;
    public static int BombAvaiable {
        get {
            return bombAvaiable;
        }
        set {
            bombAvaiable = value;
        }
    }
    private static int bombAmount = 1;
    public static int BombAmount {
        get {
            return bombAmount;
        }
        set {
            bombAmount = value;
        }
    }
}