using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument menu;
    private VisualElement contenedorBotones;
    private Button botonA;
    private Button botonB;
    private Button botonC;
    private Label textoAyuda;
    private Label creditos;
    private Button botonRegresar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Asignar referencias a los elementos de la UI
        contenedorBotones = root.Q<VisualElement>("ContenedorBotones");
        botonA = root.Q<Button>("BotonA");
        botonB = root.Q<Button>("BotonB");
        botonC = root.Q<Button>("BotonC");
        textoAyuda = root.Q<Label>("TextoAyuda");
        botonRegresar = root.Q<Button>("BotonRegresar");

        // Configurar eventos de los botones
        botonA.clicked += () => Jugar("Level1");
        botonB.clicked += MostrarTextoAyuda;
        botonC.clicked += MostrarTextoAyuda;
        botonRegresar.clicked += OcultarTextoAyuda;

        // Asegurar que el texto de ayuda y el botón de regresar estén ocultos al inicio
        textoAyuda.style.display = DisplayStyle.None;
        botonRegresar.style.display = DisplayStyle.None;
    }

    private void Jugar(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    private void MostrarTextoAyuda()
    {
        // Ocultar los botones principales y mostrar el texto de ayuda y el botón de regresar
        botonA.style.display = DisplayStyle.None;
        botonB.style.display = DisplayStyle.None;
        botonC.style.display = DisplayStyle.None;
        textoAyuda.style.display = DisplayStyle.Flex;
        botonRegresar.style.display = DisplayStyle.Flex;
    }

    private void OcultarTextoAyuda()
    {
        // Mostrar los botones principales y ocultar el texto de ayuda y el botón de regresar
        botonA.style.display = DisplayStyle.Flex;
        botonB.style.display = DisplayStyle.Flex;
        botonC.style.display = DisplayStyle.Flex;
        textoAyuda.style.display = DisplayStyle.None;
        botonRegresar.style.display = DisplayStyle.None;
    }

}
