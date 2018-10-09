using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030A RID: 778
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomTalent")]
	[Serializable]
	public class RandomTalent : IExtensible
	{
		// Token: 0x06002E89 RID: 11913 RVA: 0x000B9EB4 File Offset: 0x000B80B4
		public RandomTalent()
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000B9F1C File Offset: 0x000B811C
		// (set) Token: 0x06002E8B RID: 11915 RVA: 0x000B9F24 File Offset: 0x000B8124
		[ProtoMember(1, IsRequired = true, Name = "SkillId", DataFormat = DataFormat.TwosComplement)]
		public int SkillId
		{
			get
			{
				return this._SkillId;
			}
			set
			{
				this._SkillId = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000B9F30 File Offset: 0x000B8130
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x000B9F38 File Offset: 0x000B8138
		[ProtoMember(2, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000B9F44 File Offset: 0x000B8144
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000B9F54 File Offset: 0x000B8154
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

		// Token: 0x06002E90 RID: 11920 RVA: 0x000BA020 File Offset: 0x000B8220
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomTalent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023B1 RID: 9137
		private int _SkillId;

		// Token: 0x040023B2 RID: 9138
		private int _Weight;

		// Token: 0x040023B3 RID: 9139
		private IExtension extensionObject;

		// Token: 0x040023B4 RID: 9140
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023B5 RID: 9141
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023B6 RID: 9142
		private LuaFunction m_ctor_hotfix;
	}
}
