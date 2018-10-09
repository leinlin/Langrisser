using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B5 RID: 1717
	[ProtoContract(Name = "LevelDanmakuGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class LevelDanmakuGetAck : IExtensible
	{
		// Token: 0x06005CF8 RID: 23800 RVA: 0x001A73A8 File Offset: 0x001A55A8
		public LevelDanmakuGetAck()
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

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x001A7410 File Offset: 0x001A5610
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x001A7418 File Offset: 0x001A5618
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

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06005CFB RID: 23803 RVA: 0x001A7424 File Offset: 0x001A5624
		// (set) Token: 0x06005CFC RID: 23804 RVA: 0x001A742C File Offset: 0x001A562C
		[ProtoMember(2, IsRequired = false, Name = "LevelDanmaku", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProLevelDanmaku LevelDanmaku
		{
			get
			{
				return this._LevelDanmaku;
			}
			set
			{
				this._LevelDanmaku = value;
			}
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x001A7438 File Offset: 0x001A5638
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x001A7448 File Offset: 0x001A5648
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

		// Token: 0x06005CFF RID: 23807 RVA: 0x001A7514 File Offset: 0x001A5714
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelDanmakuGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400458A RID: 17802
		private int _Result;

		// Token: 0x0400458B RID: 17803
		private ProLevelDanmaku _LevelDanmaku;

		// Token: 0x0400458C RID: 17804
		private IExtension extensionObject;

		// Token: 0x0400458D RID: 17805
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400458E RID: 17806
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400458F RID: 17807
		private LuaFunction m_ctor_hotfix;
	}
}
