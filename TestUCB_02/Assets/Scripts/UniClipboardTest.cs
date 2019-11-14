using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniClipboardTest : MonoBehaviour
{
    /// コピーボタン
	[SerializeField] private Button _copyButton;
    /// id入力
    [SerializeField] private InputField _input;
    
    void Awake()
    {
        _copyButton.onClick.AddListener( () => {
			UniClipboard.SetText ( _input.text );
        });
    }
}
