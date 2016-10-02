namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class UI_Interactions : MonoBehaviour
    {
        public GameObject furnitureHolder;
        private UI_CubeHolder holder;
        private const int EXISTING_CANVAS_COUNT = 4;

        void Start ()
        {
            holder = furnitureHolder.GetComponent<UI_CubeHolder>();
        }

        public void Button_Red()
        {
            Debug.Log("Red Button Clicked");
        }

        public void Spawn_Chair()
        {
            GameObject cubes = holder.chairToSpawn;
            Transform placeToSpawn = holder.chairPlaceSpawn;
            Debug.Log("Spawning Cubes");
            Instantiate(cubes, placeToSpawn.position, transform.rotation);
        }

        public void Spawn_Sofa()
        {
            GameObject sofa = holder.sofaToSpawn;
            Transform placeToSpawn = holder.sofaPlaceSpawn;
            Instantiate(sofa, placeToSpawn.position, transform.rotation);
        }

        public void Spawn_Fridge()
        {
            GameObject fridge = holder.fridgeToSpawn;
            Transform placeToSpawn = holder.fridgePlaceSpawn;
            Instantiate(fridge, placeToSpawn.position, transform.rotation);
        }

        public void SpawnTV()
        {
            GameObject television = holder.tvToSpawn;
            Transform placeToSpawn = holder.tvPlaceSpawn;
            Instantiate(television, placeToSpawn.position, transform.rotation);
        }

        public void SpawnLamp()
        {
            GameObject lamp = holder.lampToSpawn;
            Transform placeToSpawn = holder.lampPlaceSpawn;
            Instantiate(lamp, placeToSpawn.position, transform.rotation);
        }

        public void SpawnTable()
        {
            GameObject table = holder.tableToSpawn;
            Transform placeToSpawn = holder.tablePlaceSpawn;
            Instantiate(table, placeToSpawn.position, transform.rotation);
        }

        public void SpawnBed()
        {
            GameObject bed = holder.bedToSpawn;
            Transform placeToSpawn = holder.bedPlaceSpawn;
            Instantiate(bed, placeToSpawn.position, transform.rotation);
        }

        public void SpawnDrawer()
        {
            GameObject drawer = holder.drawerToSpawn;
            Transform placeToSpawn = holder.drawerPlaceSpawn;
            Instantiate(drawer, placeToSpawn.position, transform.rotation);
        }

        public void SpawnDesk()
        {
            GameObject desk = holder.deskToSpawn;
            Transform placeToSpawn = holder.deskPlaceSpawn;
            Instantiate(desk, placeToSpawn.position, transform.rotation);
        }

        public void SpawnSmallLamp()
        {
            GameObject smallLamp = holder.smallLampToSpawn;
            Transform placeToSpawn = holder.smallLampPlaceSpawn;
            Instantiate(smallLamp, placeToSpawn.position, transform.rotation);
        }

        public void Restart()
        {
            SceneManager.LoadScene("Demo");
        }

        public void Button_Pink()
        {
            Debug.Log("Pink Button Clicked");
        }

        public void Toggle(bool state)
        {
            Debug.Log("The toggle state is " + (state ? "on" : "off"));
        }

        public void Dropdown(int value)
        {
            Debug.Log("Dropdown option selected was ID " + value);
        }

        public void CreateCanvas()
        {
            var canvasCount = FindObjectsOfType<Canvas>().Length - EXISTING_CANVAS_COUNT;
            var newCanvasGO = new GameObject("TempCanvas");
            newCanvasGO.layer = 5;
            var canvas = newCanvasGO.AddComponent<Canvas>();
            var canvasRT = canvas.GetComponent<RectTransform>();
            canvasRT.position = new Vector3(-4f, 2f, 2f + canvasCount);
            canvasRT.sizeDelta = new Vector2(300f, 400f);
            canvasRT.localScale = new Vector3(0.005f, 0.005f, 0.005f);
            canvasRT.eulerAngles = new Vector3(0f, 270f, 0f);

            var newButtonGO = new GameObject("TempButton");
            newButtonGO.transform.parent = newCanvasGO.transform;
            newButtonGO.layer = 5;

            newButtonGO.AddComponent<RectTransform>();

            var buttonRT = newButtonGO.GetComponent<RectTransform>();
            buttonRT.position = new Vector3(0f, 0f, 0f);
            buttonRT.anchoredPosition = new Vector3(0f, 0f, 0f);
            buttonRT.localPosition = new Vector3(0f, 0f, 0f);
            buttonRT.sizeDelta = new Vector2(180f, 60f);
            buttonRT.localScale = new Vector3(1f, 1f, 1f);
            buttonRT.localEulerAngles = new Vector3(0f, 0f, 0f);

            newButtonGO.AddComponent<Image>();
            var canvasButton = newButtonGO.AddComponent<Button>();
            var buttonColourBlock = canvasButton.colors;
            buttonColourBlock.highlightedColor = Color.red;
            canvasButton.colors = buttonColourBlock;

            var newTextGO = new GameObject("BtnText");
            newTextGO.transform.parent = newButtonGO.transform;
            newTextGO.layer = 5;

            var textRT = newTextGO.AddComponent<RectTransform>();
            textRT.position = new Vector3(0f, 0f, 0f);
            textRT.anchoredPosition = new Vector3(0f, 0f, 0f);
            textRT.localPosition = new Vector3(0f, 0f, 0f);
            textRT.sizeDelta = new Vector2(180f, 60f);
            textRT.localScale = new Vector3(1f, 1f, 1f);
            textRT.localEulerAngles = new Vector3(0f, 0f, 0f);

            var txt = newTextGO.AddComponent<Text>();
            txt.text = "New Button";
            txt.color = Color.black;
            txt.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

            FindObjectOfType<VRTK_UIPointer>().SetWorldCanvas(canvas);
        }
    }
}