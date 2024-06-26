static class Escape{
static string[] incognitasSalas = {"a","b"};
static int estadoJuego = 1;

private static void InicializarJuego(){}

public static int GetEstadoJuego(){
    return estadoJuego;
    }

public static bool ResolverSala(int Sala, string Incognita){
    int _estadoJuego = GetEstadoJuego();
    bool resuelto;  
    string respuesta = incognitasSalas[_estadoJuego-1];
    if(Sala != estadoJuego)
    {
        return false;
    }
    if (incognitasSalas[_estadoJuego-1] == Incognita){
        resuelto = true;
        estadoJuego++;
    }
    else{
        resuelto = false;
    }
    return resuelto;
}
}