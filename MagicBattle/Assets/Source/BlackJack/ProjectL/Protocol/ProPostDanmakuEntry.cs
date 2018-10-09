using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000670 RID: 1648
	[ProtoContract(Name = "ProPostDanmakuEntry")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProPostDanmakuEntry : IExtensible
	{
		// Token: 0x060059D6 RID: 22998 RVA: 0x0019EA30 File Offset: 0x0019CC30
		public ProPostDanmakuEntry()
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

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x060059D7 RID: 22999 RVA: 0x0019EA98 File Offset: 0x0019CC98
		// (set) Token: 0x060059D8 RID: 23000 RVA: 0x0019EAA0 File Offset: 0x0019CCA0
		[ProtoMember(1, IsRequired = true, Name = "Turn", DataFormat = DataFormat.TwosComplement)]
		public int Turn
		{
			get
			{
				return this._Turn;
			}
			set
			{
				this._Turn = value;
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x060059D9 RID: 23001 RVA: 0x0019EAAC File Offset: 0x0019CCAC
		// (set) Token: 0x060059DA RID: 23002 RVA: 0x0019EAB4 File Offset: 0x0019CCB4
		[ProtoMember(2, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x0019EAC0 File Offset: 0x0019CCC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x0019EAD0 File Offset: 0x0019CCD0
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

		// Token: 0x060059DD RID: 23005 RVA: 0x0019EB9C File Offset: 0x0019CD9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProPostDanmakuEntry));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004359 RID: 17241
		private int _Turn;

		// Token: 0x0400435A RID: 17242
		private string _Content;

		// Token: 0x0400435B RID: 17243
		private IExtension extensionObject;

		// Token: 0x0400435C RID: 17244
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400435D RID: 17245
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400435E RID: 17246
		private LuaFunction m_ctor_hotfix;
	}
}
