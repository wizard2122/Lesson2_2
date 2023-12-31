using UnityEngine;

public class MediatorBootstrap : MonoBehaviour
{
    [SerializeField] private GameplayMediator _gameplayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;

    private Level _level;

    private void Awake()
    {
        _level = new Level();

        _gameplayMediator.Initialize(_level);
        _defeatPanel.Initalize(_gameplayMediator);

        _level.Start();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            _level.OnDefeat();
    }
}
