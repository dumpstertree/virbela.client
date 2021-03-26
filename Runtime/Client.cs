using UnityEngine;
using TinyMessenger;
using Virbela.Events;

namespace Virbela {

	public class Client {

		[RuntimeInitializeOnLoadMethod]
		public static void Init () {
			new Client();
		}

		public Client () {

			Debug.Log( "--Client Initialized--" );

			TinyMessengerHub.Instance.Subscribe<ToggleChangedEvent>( HandleToggleChanged );
			TinyMessengerHub.Instance.Subscribe<SliderChangedEvent>( HandleSliderChanged );
			TinyMessengerHub.Instance.Subscribe<FieldChangedEvent>( HandleFieldChanged );
		}


		private TinyMessengerHub messageHub;

		private void HandleToggleChanged ( ToggleChangedEvent evnt ) {

			Debug.Log( $"Toggle was changed to a value of '{evnt.Value}'" );
		}
		private void HandleSliderChanged ( SliderChangedEvent evnt ) {

			Debug.Log( $"Slider was changed to a value of '{evnt.Value}'" );
		}
		private void HandleFieldChanged ( FieldChangedEvent evnt ) {

			Debug.Log( $"Field was changed to a value of '{evnt.Value}'" );
		}
	}
}