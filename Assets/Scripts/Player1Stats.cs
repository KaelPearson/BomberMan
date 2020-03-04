public static class Player1Stats {

    private static float movementSpeed = 3;
    public static float MovementSpeed {
        get {
            return movementSpeed;
        } set {
            movementSpeed = value;
        }
    }

    private static int bombSize = 1;
    public static int BombSize {
        get {
            return bombSize;
        } set {
            bombSize = value;
        }
    }
    private static int bombAvaiable = 1;
    public static int BombAvaiable {
        get {
            return bombAvaiable;
        } set {
            bombAvaiable = value;
        }
    }
}