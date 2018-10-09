using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CC RID: 1996
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ModelSkinWearAck")]
	[Serializable]
	public class ModelSkinWearAck : IExtensible
	{
		// Token: 0x060065FC RID: 26108 RVA: 0x001C784C File Offset: 0x001C5A4C
		public ModelSkinWearAck()
		{
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

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x001C78B4 File Offset: 0x001C5AB4
		// (set) Token: 0x060065FE RID: 26110 RVA: 0x001C78BC File Offset: 0x001C5ABC
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x001C78C8 File Offset: 0x001C5AC8
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x001C78D0 File Offset: 0x001C5AD0
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x001C78DC File Offset: 0x001C5ADC
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x001C78E4 File Offset: 0x001C5AE4
		[ProtoMember(3, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x001C78F0 File Offset: 0x001C5AF0
		// (set) Token: 0x06006604 RID: 26116 RVA: 0x001C78F8 File Offset: 0x001C5AF8
		[ProtoMember(4, IsRequired = true, Name = "modelSkinId", DataFormat = DataFormat.TwosComplement)]
		public int ModelSkinId
		{
			get
			{
				return this._modelSkinId;
			}
			set
			{
				this._modelSkinId = value;
			}
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x001C7904 File Offset: 0x001C5B04
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x001C7914 File Offset: 0x001C5B14
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x001C79E0 File Offset: 0x001C5BE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ModelSkinWearAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C68 RID: 19560
		private int _Result;

		// Token: 0x04004C69 RID: 19561
		private int _HeroId;

		// Token: 0x04004C6A RID: 19562
		private int _JobRelatedId;

		// Token: 0x04004C6B RID: 19563
		private int _modelSkinId;

		// Token: 0x04004C6C RID: 19564
		private IExtension extensionObject;

		// Token: 0x04004C6D RID: 19565
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C6E RID: 19566
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C6F RID: 19567
		private LuaFunction m_ctor_hotfix;
	}
}
