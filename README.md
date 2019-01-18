# 手順書
1. ビルドする
2. 起動する
3. 
<img width="259" alt="2019-01-14 18 20 05" src="https://user-images.githubusercontent.com/22199654/51373684-14ab2f80-1b44-11e9-8302-4d15b9ef9753.PNG">
起動するとこの画面になるのである程度メッシュを認識させたら中央のボタンをタップ

4. [ここ](https://s3-ap-northeast-1.amazonaws.com/sada.work2/test.obj)に中身がアップロードされるのでダウンロード
5. obj命式の文字列があるのでブレンダーやMaya等で開いてUV展開
バグったオブジェクトがあったら消したほうがいいかもしれない
この際左右が反転してるのでxの大きさを-1倍にする

6. fbx形式でエクスポート
7. ARSceneをの中に先ほど作ったfbxを入れる
8. 作ったモデルのprefabに
- MeshCollider
- inkCanvas
をアタッチ
<img width="478" alt="2019-01-18 17 21 49" src="https://user-images.githubusercontent.com/22199654/51374326-05c57c80-1b46-11e9-92f0-1044869a55b5.png">
をアタッチ
その後透明なテクスチャを入れたマテリアルをアタッチ
<img width="478" alt="2019-01-18 17 29 33" src="https://user-images.githubusercontent.com/22199654/51374534-ad42af00-1b46-11e9-9004-d07f6f5b830a.png">

9. その後ビルドして起動
さっきの画面の左下の戻るボタンでをタップするとモデルを配置したシーンに移動する
<img width="259" alt="2019-01-14 18 20 05" src="https://user-images.githubusercontent.com/22199654/51373684-14ab2f80-1b44-11e9-8302-4d15b9ef9753.PNG">

# その他
ここの数値を変えると取れるメッシュの広さが変わる（っぽい）
デフォルトでは1mだったがこのままだとobjに変換した際おかしなメッシュが生成された
自分の部屋では5mくらいがちょうどよかった気がする
<img width="598" alt="2019-01-18 17 36 13" src="https://user-images.githubusercontent.com/22199654/51374849-98b2e680-1b47-11e9-9360-f4906d76e82f.png">

