// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Launcher.cs" company="Exit Games GmbH">
//   Part of: Photon Unity Networking Demos
// </copyright>
// <summary>
//  Used in "PUN Basic tutorial" to handle typical game management requirements
// </summary>
// <author>developer@exitgames.com</author>
// --------------------------------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;

using Photon.Realtime;

namespace Photon.Pun.Demo.PunBasics
{
	#pragma warning disable 649

	/// <summary>
	/// Game manager.
	/// Connects and watch Photon Status, Instantiate Player
	/// Deals with quiting the room and the game
	/// Deals with level loading (outside the in room synchronization)
	/// </summary>
	public class GameManager : MonoBehaviourPunCallbacks
    {

		#region Public Fields

		static public GameManager Instance;

		#endregion

		#region Private Fields

		private GameObject instance;

        [Tooltip("The prefab to use for representing the player 1")]
        [SerializeField]
        private GameObject Player1Prefab;

				[Tooltip("The prefab to use for representing the player 2")]
        [SerializeField]
        private GameObject Player2Prefab;

				[Tooltip("The prefab to use for representing the player 3")]
				[SerializeField]
				private GameObject Player3Prefab;

				[Tooltip("The prefab to use for representing the player 4")]
				[SerializeField]
				private GameObject Player4Prefab;


        #endregion

        #region MonoBehaviour CallBacks

        /// <summary>
        /// MonoBehaviour method called on GameObject by Unity during initialization phase.
        /// </summary>
        void Start()
		{
			Instance = this;

			// in case we started this demo with the wrong scene being active, simply load the menu scene
			if (!PhotonNetwork.IsConnected)
			{
				SceneManager.LoadScene("PunBasics-Launcher");

				return;
			}

			if (Player1Prefab == null) { // #Tip Never assume public properties of Components are filled up properly, always check and inform the developer of it.

				Debug.LogError("<Color=Red><b>Missing</b></Color> Player1Prefab Reference. Please set it up in GameObject 'Game Manager'", this);
			} else if (Player2Prefab == null) {
				Debug.LogError("<Color=Red><b>Missing</b></Color> Player2Prefab Reference. Please set it up in GameObject 'Game Manager'", this);
			} else if (Player3Prefab == null) {
				Debug.LogError("<Color=Red><b>Missing</b></Color> Player3Prefab Reference. Please set it up in GameObject 'Game Manager'", this);
			} else if (Player4Prefab == null) {
				Debug.LogError("<Color=Red><b>Missing</b></Color> Player4Prefab Reference. Please set it up in GameObject 'Game Manager'", this);
			}	else {


			if (PlayerManager.LocalPlayerInstance==null)
			{
			    Debug.LogFormat("We are Instantiating LocalPlayer from {0}", SceneManagerHelper.ActiveSceneName);

<<<<<<< HEAD
=======
					// we're in a room. spawn a character for the local player. it gets synced by using PhotonNetwork.Instantiate
					PhotonNetwork.Instantiate(this.playerPrefab.name, new Vector3(0f,5f,0f), Quaternion.identity, 0);
				}else{
>>>>>>> parent of 0df1754... added tracking to networking of the htc viv rig

				// we're in a room. spawn a character for the local player. it gets synced by using PhotonNetwork.Instantiate
				if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
				{
					Debug.Log("We load first player");

					// #Critical
					PhotonNetwork.Instantiate(this.Player1Prefab.name, new Vector3(0f,0f,0f), Quaternion.identity, 0);
				} else if (PhotonNetwork.CurrentRoom.PlayerCount == 2) {
					PhotonNetwork.Instantiate(this.Player2Prefab.name, new Vector3(0f,6f,0f), Quaternion.identity, 0);
				} else if (PhotonNetwork.CurrentRoom.PlayerCount == 3) {
					PhotonNetwork.Instantiate(this.Player3Prefab.name, new Vector3(0f,6f,0f), Quaternion.identity, 0);
				} else if (PhotonNetwork.CurrentRoom.PlayerCount == 4) {
					PhotonNetwork.Instantiate(this.Player4Prefab.name, new Vector3(0f,6f,0f), Quaternion.identity, 0);
				} else {
					Debug.Log("more people in room then max of 4");
				}

			}else{

				Debug.LogFormat("Ignoring scene load for {0}", SceneManagerHelper.ActiveSceneName);
			}


			}

		}

		/// <summary>
		/// MonoBehaviour method called on GameObject by Unity on every frame.
		/// </summary>
		void Update()
		{
<<<<<<< HEAD

            // "back" button of phone equals "Escape". quit app if that's pressed
            if (Input.GetKeyDown(KeyCode.Escape))
=======
			// "back" button of phone equals "Escape". quit app if that's pressed
			if (Input.GetKeyDown(KeyCode.Escape))
>>>>>>> parent of 0df1754... added tracking to networking of the htc viv rig
			{
				QuitApplication();
			}
		}

        #endregion

        #region Photon Callbacks

        /// <summary>
        /// Called when a Photon Player got connected. We need to then load a bigger scene.
        /// </summary>
        /// <param name="other">Other.</param>
        public override void OnPlayerEnteredRoom( Player other  )
		{
			Debug.Log( "OnPlayerEnteredRoom() " + other.NickName); // not seen if you're the player connecting

			if ( PhotonNetwork.IsMasterClient )
			{
				Debug.LogFormat( "OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient ); // called before OnPlayerLeftRoom

				LoadArena();
<<<<<<< HEAD

      }
=======
			}
>>>>>>> parent of 0df1754... added tracking to networking of the htc viv rig
		}

		/// <summary>
		/// Called when a Photon Player got disconnected. We need to load a smaller scene.
		/// </summary>
		/// <param name="other">Other.</param>
		public override void OnPlayerLeftRoom( Player other  )
		{
			Debug.Log( "OnPlayerLeftRoom() " + other.NickName ); // seen when other disconnects

			if ( PhotonNetwork.IsMasterClient )
			{
				Debug.LogFormat( "OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient ); // called before OnPlayerLeftRoom

				LoadArena();
			}
		}

		/// <summary>
		/// Called when the local player left the room. We need to load the launcher scene.
		/// </summary>
		public override void OnLeftRoom()
		{
			SceneManager.LoadScene("PunBasics-Launcher");
		}

		#endregion

		#region Public Methods

		public void LeaveRoom()
		{
			PhotonNetwork.LeaveRoom();
		}

		public void QuitApplication()
		{
			Application.Quit();
		}

		#endregion

		#region Private Methods

		void LoadArena()
		{
			if ( ! PhotonNetwork.IsMasterClient )
			{
				Debug.LogError( "PhotonNetwork : Trying to Load a level but we are not the master Client" );
			}

			Debug.LogFormat( "PhotonNetwork : Loading Level : {0}", PhotonNetwork.CurrentRoom.PlayerCount );

			PhotonNetwork.LoadLevel("PunBasics-Room for "+PhotonNetwork.CurrentRoom.PlayerCount);
		}

		#endregion

	}

}
