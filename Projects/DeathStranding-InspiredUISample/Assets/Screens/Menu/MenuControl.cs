using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace PanelSettings.DeathStranding {

	[UxmlElement]
	public partial class MenuControl : VisualElement {

		VisualElement firstButton;
		List< VisualElement > buttonList;

		public MenuControl() {
			RegisterCallbackOnce< GeometryChangedEvent >( FirstFrameInit );
		}

		void FirstFrameInit( GeometryChangedEvent evt ) {
			if ( childCount == 0 )
				return;

			var children = Children();

			firstButton = children.First();

			buttonList = new List<VisualElement>();
			buttonList.AddRange( Children() );

			foreach ( var button in buttonList ) {
				button.RegisterCallback< ClickEvent >( ButtonClick );
			}

			firstButton.Focus();
		}

		void ButtonClick( ClickEvent evt ) {
			var button = evt.target as VisualElement;
			var offset = firstButton.resolvedStyle.marginTop - button.layout.yMin;

			style.translate = new Vector3( 0f, offset, 0f );
		}

	}

}
