using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000290 RID: 656
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSpineAnimationSoundTable")]
	[Serializable]
	public class ConfigDataSpineAnimationSoundTable : IExtensible
	{
		// Token: 0x06002B4D RID: 11085 RVA: 0x000B2680 File Offset: 0x000B0880
		public ConfigDataSpineAnimationSoundTable()
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

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000B26E8 File Offset: 0x000B08E8
		// (set) Token: 0x06002B4F RID: 11087 RVA: 0x000B26F0 File Offset: 0x000B08F0
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000B26FC File Offset: 0x000B08FC
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x000B2704 File Offset: 0x000B0904
		[ProtoMember(3, IsRequired = true, Name = "SpineDataName", DataFormat = DataFormat.Default)]
		public string SpineDataName
		{
			get
			{
				return this._SpineDataName;
			}
			set
			{
				this._SpineDataName = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000B2710 File Offset: 0x000B0910
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x000B2718 File Offset: 0x000B0918
		[ProtoMember(4, IsRequired = true, Name = "AnimationName", DataFormat = DataFormat.Default)]
		public string AnimationName
		{
			get
			{
				return this._AnimationName;
			}
			set
			{
				this._AnimationName = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000B2724 File Offset: 0x000B0924
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x000B272C File Offset: 0x000B092C
		[ProtoMember(5, IsRequired = true, Name = "EventName", DataFormat = DataFormat.Default)]
		public string EventName
		{
			get
			{
				return this._EventName;
			}
			set
			{
				this._EventName = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000B2738 File Offset: 0x000B0938
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x000B2740 File Offset: 0x000B0940
		[ProtoMember(6, IsRequired = true, Name = "SoundName", DataFormat = DataFormat.Default)]
		public string SoundName
		{
			get
			{
				return this._SoundName;
			}
			set
			{
				this._SoundName = value;
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000B274C File Offset: 0x000B094C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000B275C File Offset: 0x000B095C
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

		// Token: 0x06002B5A RID: 11098 RVA: 0x000B2828 File Offset: 0x000B0A28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSpineAnimationSoundTable));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AA2 RID: 6818
		private int _ID;

		// Token: 0x04001AA3 RID: 6819
		private string _SpineDataName;

		// Token: 0x04001AA4 RID: 6820
		private string _AnimationName;

		// Token: 0x04001AA5 RID: 6821
		private string _EventName;

		// Token: 0x04001AA6 RID: 6822
		private string _SoundName;

		// Token: 0x04001AA7 RID: 6823
		private IExtension extensionObject;

		// Token: 0x04001AA8 RID: 6824
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AA9 RID: 6825
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AAA RID: 6826
		private LuaFunction m_ctor_hotfix;
	}
}
