using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace PanelSettings.UI.Editor {

	class TestWindow : EditorWindow {

		[SerializeField]
		public VisualTreeAsset defaultUxml;
		
		[ MenuItem( "Window/PanelSettings/Test Window" ) ]
		static void Init() {
			var window = EditorWindow.GetWindow< TestWindow >();
			window.Show();
		}

		void CreateGUI() {
			if ( !defaultUxml ) {
				rootVisualElement.Add( new Label( "No uxml given." ) );
				return;
			}

			defaultUxml.CloneTree( rootVisualElement );
		}
	}

}