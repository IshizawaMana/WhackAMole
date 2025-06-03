Whack-A-Mole（モグラ叩きゲーム）

技術要点

使用技術
- Unity
- C#スクリプト
- Unity UI（TextMeshPro)

実装内容
- `OnMouseDown()` によるクリック検知
- プレハブ（Prefab）を使ったモグラの再利用
- `Transform.Translate()` によるモグラの上下移動
- `Random.Range()` による出現位置・タイミングのランダム化
- スコア加算ロジック（1回のみ加算）
- `TextMeshPro` によるスコア表示
- `GameManager` による全体制御
- Prefab を使ったモグラと地面の一括管理
