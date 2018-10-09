using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000984 RID: 2436
	[HotFix]
	public class ClientWorldPlayerActor : Entity
	{
		// Token: 0x06008BE6 RID: 35814 RVA: 0x0028D11C File Offset: 0x0028B31C
		public ClientWorldPlayerActor()
		{
			this.m_isVisible = true;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x0028D194 File Offset: 0x0028B394
		public void Initialize(ClientWorld world)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientWorld_hotfix != null)
			{
				this.m_InitializeClientWorld_hotfix.call(new object[]
				{
					this,
					world
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld = world;
			this.m_id = world.GetNextEntityId();
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(world.PlayerUIPrefab, world.PlayerUIRoot.transform, false);
			if (gameObject != null)
			{
				gameObject.name = "Player";
				this.m_uiController = GameObjectUtility.AddControllerToGameObject<WorldPlayerActorUIController>(gameObject);
				gameObject.transform.localRotation = ClientWorldConst.FaceCameraRotation;
			}
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x0028D264 File Offset: 0x0028B464
		public void CreateGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo heroSkinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_CreateGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					heroSkinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (jobConnectionInfo == null)
			{
				return;
			}
			string text = string.Empty;
			if (heroSkinResInfo != null)
			{
				text = heroSkinResInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = jobConnectionInfo.Model;
			}
			if (this.m_graphic != null && this.m_graphic.AssetName == text)
			{
				return;
			}
			this.DestroyGraphic();
			this.m_graphic = this.m_clientWorld.CreateGraphic(text, 0.6f);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
				this.m_graphic.SetName("Player");
				this.m_graphic.SetRotation(ClientWorldConst.FaceCameraRotation);
				this.m_graphic.SetSortingOrder(2);
			}
			this.Locate(this.m_position, this.m_direction);
			this.PlayAnimation("idle", true);
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x0028D3B8 File Offset: 0x0028B5B8
		private void DestroyGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphic_hotfix != null)
			{
				this.m_DestroyGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_clientWorld.DestroyGraphic(this.m_graphic);
				this.m_graphic = null;
			}
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x0028D43C File Offset: 0x0028B63C
		public override void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			if (this.m_uiController != null)
			{
				UnityEngine.Object.Destroy(this.m_uiController.gameObject);
				this.m_uiController = null;
			}
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x0028D4CC File Offset: 0x0028B6CC
		public override void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x0028D52C File Offset: 0x0028B72C
		public override void TickGraphic(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickGraphicSingle_hotfix != null)
			{
				this.m_TickGraphicSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_movePath.Count > 0)
			{
				ClientWorldWaypoint clientWorldWaypoint = this.m_movePath[0];
				int dir = this.m_direction;
				if (clientWorldWaypoint.Position.x > this.m_position.x)
				{
					dir = 1;
				}
				else if (clientWorldWaypoint.Position.x < this.m_position.x)
				{
					dir = -1;
				}
				Vector2 vector = Vector2.MoveTowards(this.m_position, clientWorldWaypoint.Position, dt * 5f);
				this.Locate(vector, dir);
				this.m_clientWorld.WorldCamera.SetFollowPosition(vector);
				if ((this.m_position - clientWorldWaypoint.Position).sqrMagnitude < 0.001f)
				{
					this.Locate(clientWorldWaypoint.Position, dir);
					this.m_movePath.RemoveAt(0);
					if (this.m_movePath.Count == 0)
					{
						this.PlayAnimation("idle", true);
						if (this.m_onMoveEnd != null)
						{
							this.m_onMoveEnd();
							this.m_onMoveEnd = null;
						}
					}
				}
			}
			if (this.m_teleportWaypoint != null)
			{
				if (this.m_teleportAppearCountdown > 0f)
				{
					this.m_teleportAppearCountdown -= dt;
					if (this.m_teleportAppearCountdown <= 0f)
					{
						this.m_teleportAppearCountdown = 0f;
						this.m_teleportEndActionCountdown = 0.7f;
						this.Locate(this.m_teleportWaypoint.Position, this.m_direction);
						this.SetVisible(true);
						Vector3 p = new Vector3(this.m_position.x, this.m_position.y, -0.01f);
						this.PlayFx("FX/Common_ABS/CommonFX/common_Teleport_2end.prefab", p);
						this.m_clientWorld.WorldCamera.StartFollow();
						this.m_clientWorld.WorldCamera.SetFollowPosition(this.m_position);
					}
				}
				else if (this.m_teleportEndActionCountdown > 0f)
				{
					this.m_teleportEndActionCountdown -= dt;
					if (this.m_teleportEndActionCountdown <= 0f)
					{
						this.m_teleportEndActionCountdown = 0f;
						this.m_teleportWaypoint = null;
						if (this.m_onTeleportEnd != null)
						{
							this.m_onTeleportEnd();
							this.m_onTeleportEnd = null;
						}
					}
				}
			}
			if (this.m_graphic != null)
			{
				this.m_graphic.Tick(dt);
			}
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x0028D7EC File Offset: 0x0028B9EC
		public override void Draw()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Draw_hotfix != null)
			{
				this.m_Draw_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x0028D84C File Offset: 0x0028BA4C
		public override void DoPause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPauseBoolean_hotfix != null)
			{
				this.m_DoPauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Pause(pause);
			}
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x0028D8D4 File Offset: 0x0028BAD4
		public void Locate(Vector2 p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateVector2Int32_hotfix != null)
			{
				this.m_LocateVector2Int32_hotfix.call(new object[]
				{
					this,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			this.m_direction = dir;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetPosition(ClientWorld.ComputeActorPosition(this.m_position, -0.08f));
				this.m_graphic.SetDirection(this.m_direction);
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.transform.localPosition = ClientWorld.ComputeActorPosition(this.m_position, -0.099999994f);
			}
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x0028D9CC File Offset: 0x0028BBCC
		public void Locate(ConfigDataWaypointInfo waypointInfo, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateConfigDataWaypointInfoInt32_hotfix != null)
			{
				this.m_LocateConfigDataWaypointInfoInt32_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (waypointInfo == null)
			{
				return;
			}
			this.m_locateWaypointInfo = waypointInfo;
			ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(waypointInfo.ID);
			if (waypoint != null)
			{
				this.Locate(waypoint.Position, dir);
			}
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x0028DA80 File Offset: 0x0028BC80
		public void MovePath(List<int> path, Action onMoveEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MovePathList`1Action_hotfix != null)
			{
				this.m_MovePathList`1Action_hotfix.call(new object[]
				{
					this,
					path,
					onMoveEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_movePath.Clear();
			foreach (int waypointId in path)
			{
				ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(waypointId);
				if (waypoint != null)
				{
					this.m_movePath.Add(waypoint);
				}
			}
			if (this.m_movePath.Count > 0)
			{
				this.m_onMoveEnd = onMoveEnd;
				this.PlayAnimation("run", true);
				this.m_clientWorld.WorldCamera.StartFollow();
				this.m_clientWorld.WorldCamera.SetFollowPosition(this.m_position);
			}
			else if (onMoveEnd != null)
			{
				onMoveEnd();
			}
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x0028DBC8 File Offset: 0x0028BDC8
		public void Teleport(int waypointId, Action onTeleportEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeleportInt32Action_hotfix != null)
			{
				this.m_TeleportInt32Action_hotfix.call(new object[]
				{
					this,
					waypointId,
					onTeleportEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teleportWaypoint = this.m_clientWorld.GetWaypoint(waypointId);
			if (this.m_teleportWaypoint != null)
			{
				this.m_onTeleportEnd = onTeleportEnd;
				this.m_teleportAppearCountdown = 0.5f;
				this.m_teleportEndActionCountdown = 0f;
				Vector3 p = new Vector3(this.m_position.x, this.m_position.y, -0.01f);
				this.PlayFx("FX/Common_ABS/CommonFX/common_Teleport_2start.prefab", p);
				this.SetVisible(false);
			}
			else if (onTeleportEnd != null)
			{
				onTeleportEnd();
			}
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x0028DCC8 File Offset: 0x0028BEC8
		public bool IsMoving()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMoving_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMoving_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x0028DD38 File Offset: 0x0028BF38
		private void PlayAnimation(string name, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null && this.m_graphic.IsVisible())
			{
				this.m_graphic.PlayAnimation(name, loop);
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x0028DDE0 File Offset: 0x0028BFE0
		private void PlayFx(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxString_hotfix != null)
			{
				this.m_PlayFxString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null && this.m_graphic.IsVisible())
			{
				this.m_graphic.PlayFx(name, 0);
			}
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x0028DE78 File Offset: 0x0028C078
		private void PlayFx(string name, Vector3 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxStringVector3_hotfix != null)
			{
				this.m_PlayFxStringVector3_hotfix.call(new object[]
				{
					this,
					name,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			GenericGraphic genericGraphic = this.m_clientWorld.FxPlayer.Play(name);
			if (genericGraphic != null)
			{
				genericGraphic.SetSortingOrder(2);
				genericGraphic.SetPosition(p);
				genericGraphic.SetRotation(ClientWorldConst.FaceCameraRotation);
				genericGraphic.AutoDelete(true);
			}
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x0028DF3C File Offset: 0x0028C13C
		public void SetGraphicEffect(GraphicEffect e, float param1 = 0f, float param2 = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix != null)
			{
				this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix.call(new object[]
				{
					this,
					e,
					param1,
					param2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetEffect(e, param1, param2);
			}
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x0028DFE8 File Offset: 0x0028C1E8
		public void ClearGraphicEffect(GraphicEffect e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGraphicEffectGraphicEffect_hotfix != null)
			{
				this.m_ClearGraphicEffectGraphicEffect_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.ClearEffect(e);
			}
		}

		// Token: 0x06008BF9 RID: 35833 RVA: 0x0028E070 File Offset: 0x0028C270
		private void PlaySound(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundString_hotfix != null)
			{
				this.m_PlaySoundString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			this.m_clientWorld.PlaySound(name);
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x0028E0F8 File Offset: 0x0028C2F8
		private void PlaySound(SoundTableId id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundSoundTableId_hotfix != null)
			{
				this.m_PlaySoundSoundTableId_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld.PlaySound(id);
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x0028E174 File Offset: 0x0028C374
		public void SetVisible(bool visible)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetVisibleBoolean_hotfix != null)
			{
				this.m_SetVisibleBoolean_hotfix.call(new object[]
				{
					this,
					visible
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isVisible = visible;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetVisible(visible);
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.gameObject.SetActive(visible);
			}
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x0028E224 File Offset: 0x0028C424
		public bool IsVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isVisible;
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x0028E298 File Offset: 0x0028C498
		public Vector2 Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (Vector2)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_position;
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x0028E30C File Offset: 0x0028C50C
		public int Direction
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Direction_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Direction_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_direction;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06008BFF RID: 35839 RVA: 0x0028E380 File Offset: 0x0028C580
		public ConfigDataWaypointInfo LocateWaypointInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LocateWaypointInfo_hotfix != null)
				{
					return (ConfigDataWaypointInfo)this.m_get_LocateWaypointInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_locateWaypointInfo;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06008C00 RID: 35840 RVA: 0x0028E3F4 File Offset: 0x0028C5F4
		// (set) Token: 0x06008C01 RID: 35841 RVA: 0x0028E414 File Offset: 0x0028C614
		[DoNotToLua]
		public new ClientWorldPlayerActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientWorldPlayerActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x0028E420 File Offset: 0x0028C620
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x0028E428 File Offset: 0x0028C628
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x0028E430 File Offset: 0x0028C630
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x0028E43C File Offset: 0x0028C63C
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x0028E444 File Offset: 0x0028C644
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x0028E450 File Offset: 0x0028C650
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x0028E45C File Offset: 0x0028C65C
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x0028E464 File Offset: 0x0028C664
		private void __callDele_m_onMoveEnd()
		{
			Action onMoveEnd = this.m_onMoveEnd;
			if (onMoveEnd != null)
			{
				onMoveEnd();
			}
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x0028E484 File Offset: 0x0028C684
		private void __clearDele_m_onMoveEnd()
		{
			this.m_onMoveEnd = null;
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x0028E490 File Offset: 0x0028C690
		private void __callDele_m_onTeleportEnd()
		{
			Action onTeleportEnd = this.m_onTeleportEnd;
			if (onTeleportEnd != null)
			{
				onTeleportEnd();
			}
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x0028E4B0 File Offset: 0x0028C6B0
		private void __clearDele_m_onTeleportEnd()
		{
			this.m_onTeleportEnd = null;
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitializeClientWorld_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_CreateGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_DestroyGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_LocateVector2Int32_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_LocateConfigDataWaypointInfoInt32_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_MovePathList`1Action_hotfix = (luaObj.RawGet("MovePath") as LuaFunction);
					this.m_TeleportInt32Action_hotfix = (luaObj.RawGet("Teleport") as LuaFunction);
					this.m_IsMoving_hotfix = (luaObj.RawGet("IsMoving") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayFxString_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_PlayFxStringVector3_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix = (luaObj.RawGet("SetGraphicEffect") as LuaFunction);
					this.m_ClearGraphicEffectGraphicEffect_hotfix = (luaObj.RawGet("ClearGraphicEffect") as LuaFunction);
					this.m_PlaySoundString_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_PlaySoundSoundTableId_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_Direction_hotfix = (luaObj.RawGet("get_Direction") as LuaFunction);
					this.m_get_LocateWaypointInfo_hotfix = (luaObj.RawGet("get_LocateWaypointInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x0028E7F8 File Offset: 0x0028C9F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientWorldPlayerActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006391 RID: 25489
		private ClientWorld m_clientWorld;

		// Token: 0x04006392 RID: 25490
		private ConfigDataWaypointInfo m_locateWaypointInfo;

		// Token: 0x04006393 RID: 25491
		private List<ClientWorldWaypoint> m_movePath = new List<ClientWorldWaypoint>();

		// Token: 0x04006394 RID: 25492
		private Action m_onMoveEnd;

		// Token: 0x04006395 RID: 25493
		private float m_teleportAppearCountdown;

		// Token: 0x04006396 RID: 25494
		private float m_teleportEndActionCountdown;

		// Token: 0x04006397 RID: 25495
		private ClientWorldWaypoint m_teleportWaypoint;

		// Token: 0x04006398 RID: 25496
		private Action m_onTeleportEnd;

		// Token: 0x04006399 RID: 25497
		private GenericGraphic m_graphic;

		// Token: 0x0400639A RID: 25498
		private Vector2 m_position;

		// Token: 0x0400639B RID: 25499
		private int m_direction;

		// Token: 0x0400639C RID: 25500
		private bool m_isVisible;

		// Token: 0x0400639D RID: 25501
		private WorldPlayerActorUIController m_uiController;

		// Token: 0x0400639E RID: 25502
		[DoNotToLua]
		private ClientWorldPlayerActor.LuaExportHelper luaExportHelper;

		// Token: 0x0400639F RID: 25503
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040063A0 RID: 25504
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040063A1 RID: 25505
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040063A2 RID: 25506
		private LuaFunction m_InitializeClientWorld_hotfix;

		// Token: 0x040063A3 RID: 25507
		private LuaFunction m_CreateGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x040063A4 RID: 25508
		private LuaFunction m_DestroyGraphic_hotfix;

		// Token: 0x040063A5 RID: 25509
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040063A6 RID: 25510
		private LuaFunction m_Tick_hotfix;

		// Token: 0x040063A7 RID: 25511
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x040063A8 RID: 25512
		private LuaFunction m_Draw_hotfix;

		// Token: 0x040063A9 RID: 25513
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x040063AA RID: 25514
		private LuaFunction m_LocateVector2Int32_hotfix;

		// Token: 0x040063AB RID: 25515
		private LuaFunction m_LocateConfigDataWaypointInfoInt32_hotfix;

		// Token: 0x040063AC RID: 25516
		private LuaFunction m_MovePathList;

		// Token: 0x040063AD RID: 25517
		private LuaFunction m_TeleportInt32Action_hotfix;

		// Token: 0x040063AE RID: 25518
		private LuaFunction m_IsMoving_hotfix;

		// Token: 0x040063AF RID: 25519
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x040063B0 RID: 25520
		private LuaFunction m_PlayFxString_hotfix;

		// Token: 0x040063B1 RID: 25521
		private LuaFunction m_PlayFxStringVector3_hotfix;

		// Token: 0x040063B2 RID: 25522
		private LuaFunction m_SetGraphicEffectGraphicEffectSingleSingle_hotfix;

		// Token: 0x040063B3 RID: 25523
		private LuaFunction m_ClearGraphicEffectGraphicEffect_hotfix;

		// Token: 0x040063B4 RID: 25524
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x040063B5 RID: 25525
		private LuaFunction m_PlaySoundSoundTableId_hotfix;

		// Token: 0x040063B6 RID: 25526
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x040063B7 RID: 25527
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x040063B8 RID: 25528
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x040063B9 RID: 25529
		private LuaFunction m_get_Direction_hotfix;

		// Token: 0x040063BA RID: 25530
		private LuaFunction m_get_LocateWaypointInfo_hotfix;

		// Token: 0x02000985 RID: 2437
		public new class LuaExportHelper
		{
			// Token: 0x06008C0F RID: 35855 RVA: 0x0028E860 File Offset: 0x0028CA60
			public LuaExportHelper(ClientWorldPlayerActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008C10 RID: 35856 RVA: 0x0028E870 File Offset: 0x0028CA70
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06008C11 RID: 35857 RVA: 0x0028E880 File Offset: 0x0028CA80
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06008C12 RID: 35858 RVA: 0x0028E890 File Offset: 0x0028CA90
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06008C13 RID: 35859 RVA: 0x0028E8A0 File Offset: 0x0028CAA0
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06008C14 RID: 35860 RVA: 0x0028E8B0 File Offset: 0x0028CAB0
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06008C15 RID: 35861 RVA: 0x0028E8C0 File Offset: 0x0028CAC0
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06008C16 RID: 35862 RVA: 0x0028E8D0 File Offset: 0x0028CAD0
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x06008C17 RID: 35863 RVA: 0x0028E8E0 File Offset: 0x0028CAE0
			public void __callDele_m_onMoveEnd()
			{
				this.m_owner.__callDele_m_onMoveEnd();
			}

			// Token: 0x06008C18 RID: 35864 RVA: 0x0028E8F0 File Offset: 0x0028CAF0
			public void __clearDele_m_onMoveEnd()
			{
				this.m_owner.__clearDele_m_onMoveEnd();
			}

			// Token: 0x06008C19 RID: 35865 RVA: 0x0028E900 File Offset: 0x0028CB00
			public void __callDele_m_onTeleportEnd()
			{
				this.m_owner.__callDele_m_onTeleportEnd();
			}

			// Token: 0x06008C1A RID: 35866 RVA: 0x0028E910 File Offset: 0x0028CB10
			public void __clearDele_m_onTeleportEnd()
			{
				this.m_owner.__clearDele_m_onTeleportEnd();
			}

			// Token: 0x17001D54 RID: 7508
			// (get) Token: 0x06008C1B RID: 35867 RVA: 0x0028E920 File Offset: 0x0028CB20
			// (set) Token: 0x06008C1C RID: 35868 RVA: 0x0028E930 File Offset: 0x0028CB30
			public ClientWorld m_clientWorld
			{
				get
				{
					return this.m_owner.m_clientWorld;
				}
				set
				{
					this.m_owner.m_clientWorld = value;
				}
			}

			// Token: 0x17001D55 RID: 7509
			// (get) Token: 0x06008C1D RID: 35869 RVA: 0x0028E940 File Offset: 0x0028CB40
			// (set) Token: 0x06008C1E RID: 35870 RVA: 0x0028E950 File Offset: 0x0028CB50
			public ConfigDataWaypointInfo m_locateWaypointInfo
			{
				get
				{
					return this.m_owner.m_locateWaypointInfo;
				}
				set
				{
					this.m_owner.m_locateWaypointInfo = value;
				}
			}

			// Token: 0x17001D56 RID: 7510
			// (get) Token: 0x06008C1F RID: 35871 RVA: 0x0028E960 File Offset: 0x0028CB60
			// (set) Token: 0x06008C20 RID: 35872 RVA: 0x0028E970 File Offset: 0x0028CB70
			public List<ClientWorldWaypoint> m_movePath
			{
				get
				{
					return this.m_owner.m_movePath;
				}
				set
				{
					this.m_owner.m_movePath = value;
				}
			}

			// Token: 0x17001D57 RID: 7511
			// (get) Token: 0x06008C21 RID: 35873 RVA: 0x0028E980 File Offset: 0x0028CB80
			// (set) Token: 0x06008C22 RID: 35874 RVA: 0x0028E990 File Offset: 0x0028CB90
			public Action m_onMoveEnd
			{
				get
				{
					return this.m_owner.m_onMoveEnd;
				}
				set
				{
					this.m_owner.m_onMoveEnd = value;
				}
			}

			// Token: 0x17001D58 RID: 7512
			// (get) Token: 0x06008C23 RID: 35875 RVA: 0x0028E9A0 File Offset: 0x0028CBA0
			// (set) Token: 0x06008C24 RID: 35876 RVA: 0x0028E9B0 File Offset: 0x0028CBB0
			public float m_teleportAppearCountdown
			{
				get
				{
					return this.m_owner.m_teleportAppearCountdown;
				}
				set
				{
					this.m_owner.m_teleportAppearCountdown = value;
				}
			}

			// Token: 0x17001D59 RID: 7513
			// (get) Token: 0x06008C25 RID: 35877 RVA: 0x0028E9C0 File Offset: 0x0028CBC0
			// (set) Token: 0x06008C26 RID: 35878 RVA: 0x0028E9D0 File Offset: 0x0028CBD0
			public float m_teleportEndActionCountdown
			{
				get
				{
					return this.m_owner.m_teleportEndActionCountdown;
				}
				set
				{
					this.m_owner.m_teleportEndActionCountdown = value;
				}
			}

			// Token: 0x17001D5A RID: 7514
			// (get) Token: 0x06008C27 RID: 35879 RVA: 0x0028E9E0 File Offset: 0x0028CBE0
			// (set) Token: 0x06008C28 RID: 35880 RVA: 0x0028E9F0 File Offset: 0x0028CBF0
			public ClientWorldWaypoint m_teleportWaypoint
			{
				get
				{
					return this.m_owner.m_teleportWaypoint;
				}
				set
				{
					this.m_owner.m_teleportWaypoint = value;
				}
			}

			// Token: 0x17001D5B RID: 7515
			// (get) Token: 0x06008C29 RID: 35881 RVA: 0x0028EA00 File Offset: 0x0028CC00
			// (set) Token: 0x06008C2A RID: 35882 RVA: 0x0028EA10 File Offset: 0x0028CC10
			public Action m_onTeleportEnd
			{
				get
				{
					return this.m_owner.m_onTeleportEnd;
				}
				set
				{
					this.m_owner.m_onTeleportEnd = value;
				}
			}

			// Token: 0x17001D5C RID: 7516
			// (get) Token: 0x06008C2B RID: 35883 RVA: 0x0028EA20 File Offset: 0x0028CC20
			// (set) Token: 0x06008C2C RID: 35884 RVA: 0x0028EA30 File Offset: 0x0028CC30
			public GenericGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x17001D5D RID: 7517
			// (get) Token: 0x06008C2D RID: 35885 RVA: 0x0028EA40 File Offset: 0x0028CC40
			// (set) Token: 0x06008C2E RID: 35886 RVA: 0x0028EA50 File Offset: 0x0028CC50
			public Vector2 m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x17001D5E RID: 7518
			// (get) Token: 0x06008C2F RID: 35887 RVA: 0x0028EA60 File Offset: 0x0028CC60
			// (set) Token: 0x06008C30 RID: 35888 RVA: 0x0028EA70 File Offset: 0x0028CC70
			public int m_direction
			{
				get
				{
					return this.m_owner.m_direction;
				}
				set
				{
					this.m_owner.m_direction = value;
				}
			}

			// Token: 0x17001D5F RID: 7519
			// (get) Token: 0x06008C31 RID: 35889 RVA: 0x0028EA80 File Offset: 0x0028CC80
			// (set) Token: 0x06008C32 RID: 35890 RVA: 0x0028EA90 File Offset: 0x0028CC90
			public bool m_isVisible
			{
				get
				{
					return this.m_owner.m_isVisible;
				}
				set
				{
					this.m_owner.m_isVisible = value;
				}
			}

			// Token: 0x17001D60 RID: 7520
			// (get) Token: 0x06008C33 RID: 35891 RVA: 0x0028EAA0 File Offset: 0x0028CCA0
			// (set) Token: 0x06008C34 RID: 35892 RVA: 0x0028EAB0 File Offset: 0x0028CCB0
			public WorldPlayerActorUIController m_uiController
			{
				get
				{
					return this.m_owner.m_uiController;
				}
				set
				{
					this.m_owner.m_uiController = value;
				}
			}

			// Token: 0x06008C35 RID: 35893 RVA: 0x0028EAC0 File Offset: 0x0028CCC0
			public void DestroyGraphic()
			{
				this.m_owner.DestroyGraphic();
			}

			// Token: 0x06008C36 RID: 35894 RVA: 0x0028EAD0 File Offset: 0x0028CCD0
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x06008C37 RID: 35895 RVA: 0x0028EAE0 File Offset: 0x0028CCE0
			public void PlayFx(string name)
			{
				this.m_owner.PlayFx(name);
			}

			// Token: 0x06008C38 RID: 35896 RVA: 0x0028EAF0 File Offset: 0x0028CCF0
			public void PlayFx(string name, Vector3 p)
			{
				this.m_owner.PlayFx(name, p);
			}

			// Token: 0x06008C39 RID: 35897 RVA: 0x0028EB00 File Offset: 0x0028CD00
			public void PlaySound(string name)
			{
				this.m_owner.PlaySound(name);
			}

			// Token: 0x06008C3A RID: 35898 RVA: 0x0028EB10 File Offset: 0x0028CD10
			public void PlaySound(SoundTableId id)
			{
				this.m_owner.PlaySound(id);
			}

			// Token: 0x040063BB RID: 25531
			private ClientWorldPlayerActor m_owner;
		}
	}
}
