using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000069 RID: 105
	public static class PathHelper
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000154D4 File Offset: 0x000136D4
		public static string AssetBundlesBuildOutputPathWithPlatform
		{
			get
			{
				if (Application.isEditor)
				{
					return PathHelper.AssetBundlesBuildOutputPath + "/" + Util.GetCurrentTargetPlatform();
				}
				if (PathHelper.m_assetBundlesBuildOutputPathWithPlatform == null)
				{
					PathHelper.m_assetBundlesBuildOutputPathWithPlatform = PathHelper.AssetBundlesBuildOutputPath + "/" + Util.GetCurrentTargetPlatform();
				}
				return PathHelper.m_assetBundlesBuildOutputPathWithPlatform;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00015528 File Offset: 0x00013728
		public static string AssetBundlesDownloadPath4Editor
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("{0}/../{1}/{2}", Application.dataPath, PathHelper.AssetBundlesBuildOutputPath, Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_assetBundlesDownloadPath4Editor == null)
				{
					PathHelper.m_assetBundlesDownloadPath4Editor = string.Format("{0}/../{1}/{2}", Application.dataPath, PathHelper.AssetBundlesBuildOutputPath, Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_assetBundlesDownloadPath4Editor;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00015588 File Offset: 0x00013788
		public static string BundleDataAssetName
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("BundleData{0}", Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_bundleDataAssetName == null)
				{
					PathHelper.m_bundleDataAssetName = string.Format("BundleData{0}", Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_bundleDataAssetName;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000155C8 File Offset: 0x000137C8
		public static string BundleDataAssetPathNoPostfix
		{
			get
			{
				if (Application.isEditor)
				{
					return PathHelper.BundleDataPath + Util.GetCurrentTargetPlatform();
				}
				if (PathHelper.m_bundleDataAssetPathNoPostfix == null)
				{
					PathHelper.m_bundleDataAssetPathNoPostfix = PathHelper.BundleDataPath + Util.GetCurrentTargetPlatform();
				}
				return PathHelper.m_bundleDataAssetPathNoPostfix;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00015608 File Offset: 0x00013808
		public static string BundleDataAssetPath
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("{0}{1}.asset", PathHelper.BundleDataPath, Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_bundleDataAssetPath == null)
				{
					PathHelper.m_bundleDataAssetPath = string.Format("{0}{1}.asset", PathHelper.BundleDataPath, Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_bundleDataAssetPath;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001565C File Offset: 0x0001385C
		public static string StreamAssetBundleDataAssetPathInEditor
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("Assets/GameProject/Resources/StreamingAssetsRes/{0}.asset", PathHelper.BundleDataAssetName);
				}
				if (PathHelper.m_streamAssetBundleDataAssetPathInEditor == null)
				{
					PathHelper.m_streamAssetBundleDataAssetPathInEditor = string.Format("Assets/GameProject/Resources/StreamingAssetsRes/{0}.asset", PathHelper.BundleDataAssetName);
				}
				return PathHelper.m_streamAssetBundleDataAssetPathInEditor;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0001569C File Offset: 0x0001389C
		public static string StreamAssetBundleDataResourcesPath
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("StreamingAssetsRes/{0}", PathHelper.BundleDataAssetName);
				}
				if (PathHelper.m_streamAssetBundleDataAssetPath == null)
				{
					PathHelper.m_streamAssetBundleDataAssetPath = string.Format("StreamingAssetsRes/{0}", PathHelper.BundleDataAssetName);
				}
				return PathHelper.m_streamAssetBundleDataAssetPath;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000156DC File Offset: 0x000138DC
		public static string BundleDataBundleName
		{
			get
			{
				if (Application.isEditor)
				{
					return Util.GetBundleNameByAssetPath(PathHelper.BundleDataAssetPath);
				}
				if (PathHelper.m_bundleDataBundleName == null)
				{
					PathHelper.m_bundleDataBundleName = Util.GetBundleNameByAssetPath(PathHelper.BundleDataAssetPath);
				}
				return PathHelper.m_bundleDataBundleName;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015714 File Offset: 0x00013914
		public static string BundleDataVersionFilePath
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("{0}/{1}", PathHelper.AssetBundlesBuildOutputPathWithPlatform, PathHelper.BundleDataVersionFileName);
				}
				if (PathHelper.m_bundleDataVersionFilePath == null)
				{
					PathHelper.m_bundleDataVersionFilePath = string.Format("{0}/{1}", PathHelper.AssetBundlesBuildOutputPathWithPlatform, PathHelper.BundleDataVersionFileName);
				}
				return PathHelper.m_bundleDataVersionFilePath;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00015768 File Offset: 0x00013968
		public static string StreamingAssetsRootPath
		{
			get
			{
				if (Application.isEditor)
				{
					return Application.streamingAssetsPath;
				}
				if (PathHelper.m_streamingAssetsRootPath == null)
				{
					PathHelper.m_streamingAssetsRootPath = Application.streamingAssetsPath;
				}
				return PathHelper.m_streamingAssetsRootPath;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00015794 File Offset: 0x00013994
		public static string StreamingAssetsBundlePath
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("{0}/ExportAssetBundle", Application.streamingAssetsPath);
				}
				if (PathHelper.m_streamingAssetsBundlePath == null)
				{
					PathHelper.m_streamingAssetsBundlePath = string.Format("{0}/ExportAssetBundle", Application.streamingAssetsPath);
				}
				return PathHelper.m_streamingAssetsBundlePath;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000157D4 File Offset: 0x000139D4
		public static string StreamingAssetsFileListPath
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("Assets/GameProject/Resources/StreamingAssetsRes/StreamingAssetsFileList{0}.asset", Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_streamingAssetsFileListPath == null)
				{
					PathHelper.m_streamingAssetsFileListPath = string.Format("Assets/GameProject/Resources/StreamingAssetsRes/StreamingAssetsFileList{0}.asset", Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_streamingAssetsFileListPath;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00015814 File Offset: 0x00013A14
		public static string StreamingAssetsFileListPathNoPostfix
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("Assets/GameProject/Resources/StreamingAssetsRes/StreamingAssetsFileList{0}", Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_streamingAssetsFileListPathNoPostfix == null)
				{
					PathHelper.m_streamingAssetsFileListPathNoPostfix = string.Format("Assets/GameProject/Resources/StreamingAssetsRes/StreamingAssetsFileList{0}", Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_streamingAssetsFileListPathNoPostfix;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00015854 File Offset: 0x00013A54
		public static string StreamingAssetsFileListResourcesName
		{
			get
			{
				if (Application.isEditor)
				{
					return string.Format("StreamingAssetsRes/StreamingAssetsFileList{0}", Util.GetCurrentTargetPlatform());
				}
				if (PathHelper.m_streamingAssetsFileListResourcesName == null)
				{
					PathHelper.m_streamingAssetsFileListResourcesName = string.Format("StreamingAssetsRes/StreamingAssetsFileList{0}", Util.GetCurrentTargetPlatform());
				}
				return PathHelper.m_streamingAssetsFileListResourcesName;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00015894 File Offset: 0x00013A94
		public static string DynamicAssemblyRoot
		{
			get
			{
				return "Assets/plugins/BlackJack";
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001589C File Offset: 0x00013A9C
		public static string DynamicAssemblyAssetRoot
		{
			get
			{
				return "Assets/GameProject/RuntimeAssets/Assemblys";
			}
		}

		// Token: 0x0400023A RID: 570
		public static string AssetBundlesBuildOutputPath = "AssetBundles";

		// Token: 0x0400023B RID: 571
		private static string m_assetBundlesBuildOutputPathWithPlatform;

		// Token: 0x0400023C RID: 572
		private static string m_assetBundlesDownloadPath4Editor;

		// Token: 0x0400023D RID: 573
		public static string BundleDataPath = "Assets/GameProject/RuntimeAssets/BundleData";

		// Token: 0x0400023E RID: 574
		private static string m_bundleDataAssetName;

		// Token: 0x0400023F RID: 575
		private static string m_bundleDataAssetPathNoPostfix;

		// Token: 0x04000240 RID: 576
		private static string m_bundleDataAssetPath;

		// Token: 0x04000241 RID: 577
		private static string m_streamAssetBundleDataAssetPathInEditor;

		// Token: 0x04000242 RID: 578
		private static string m_streamAssetBundleDataAssetPath;

		// Token: 0x04000243 RID: 579
		private static string m_bundleDataBundleName;

		// Token: 0x04000244 RID: 580
		public static string BundleDataVersionFileName = "BundleDataVersion.txt";

		// Token: 0x04000245 RID: 581
		private static string m_bundleDataVersionFilePath;

		// Token: 0x04000246 RID: 582
		public static string StreamingAssetsBundlePathDirName = "ExportAssetBundle";

		// Token: 0x04000247 RID: 583
		private static string m_streamingAssetsRootPath;

		// Token: 0x04000248 RID: 584
		private static string m_streamingAssetsBundlePath;

		// Token: 0x04000249 RID: 585
		private static string m_streamingAssetsFileListPath;

		// Token: 0x0400024A RID: 586
		private static string m_streamingAssetsFileListPathNoPostfix;

		// Token: 0x0400024B RID: 587
		private static string m_streamingAssetsFileListResourcesName;
	}
}
