using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C8 RID: 1992
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CharSkinWearAck")]
	[Serializable]
	public class CharSkinWearAck : IExtensible
	{
		// Token: 0x060065DA RID: 26074 RVA: 0x001C70E8 File Offset: 0x001C52E8
		public CharSkinWearAck()
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060065DB RID: 26075 RVA: 0x001C7150 File Offset: 0x001C5350
		// (set) Token: 0x060065DC RID: 26076 RVA: 0x001C7158 File Offset: 0x001C5358
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

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x001C7164 File Offset: 0x001C5364
		// (set) Token: 0x060065DE RID: 26078 RVA: 0x001C716C File Offset: 0x001C536C
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

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x001C7178 File Offset: 0x001C5378
		// (set) Token: 0x060065E0 RID: 26080 RVA: 0x001C7180 File Offset: 0x001C5380
		[ProtoMember(3, IsRequired = true, Name = "CharSkinId", DataFormat = DataFormat.TwosComplement)]
		public int CharSkinId
		{
			get
			{
				return this._CharSkinId;
			}
			set
			{
				this._CharSkinId = value;
			}
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x001C718C File Offset: 0x001C538C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x001C719C File Offset: 0x001C539C
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

		// Token: 0x060065E3 RID: 26083 RVA: 0x001C7268 File Offset: 0x001C5468
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CharSkinWearAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C4F RID: 19535
		private int _Result;

		// Token: 0x04004C50 RID: 19536
		private int _HeroId;

		// Token: 0x04004C51 RID: 19537
		private int _CharSkinId;

		// Token: 0x04004C52 RID: 19538
		private IExtension extensionObject;

		// Token: 0x04004C53 RID: 19539
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C54 RID: 19540
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C55 RID: 19541
		private LuaFunction m_ctor_hotfix;
	}
}
