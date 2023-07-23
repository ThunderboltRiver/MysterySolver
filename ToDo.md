## 仕様
- プレイヤーは過去と現在のステージを行き来することができる
- 



謎解き関連
- プレイヤーはステージ内の記憶を見つけることができる。
- ステージ内の記憶はプレイヤーが解いてきた謎の履歴を検査し、OKならその結果としてプレイヤーの記憶を生成する
- プレイヤーは生成されたプレイヤーの記憶をリポジトリに保存する.
- その後プレイヤーの記憶に応じたステージのパーツが既存のステージに組み込まれる.
Player.Remember(Memory memory)
{
    PlayerMemory playerMemory = memory.Inspect(mysterySolvedRoute);
    if(playerMemory is not null) {
        playerBrain.Register(playerMemory);
    }
}

- ステージ内にはいくつかの謎がある
- 謎には記憶を手に入れる直前の謎(メモリーミステリーと呼ぶことにする)と、そうではない謎(ギミックと呼ぶことにする)がある

Mystery.Authenticate(ObtainedKey key);

Key.Authenticate(MysterySolvedRoute mysterySolvedRoute);

bool Player.Obtain(Key key){
    ObtainedKey obtainedKey = Key.Autenticate(this.mysterySolvedRoute);
    if(obtainedKey == null){return false;}
    this.ObtainedKeyRepository.Save(obtainedKey);
    return true;
}

bool Player.Solve(Mystery mystery,KeyId KeyId){
    ObtainedKey obtainedKey = this.obtainedKeyRepository.Find(KeyID);
    if(obtainedKey == null){return false;}
    SolvedPoint solvedPoint = mystery.Authenticate(obtainedKey);
    if(solvedPoint == null){return false;}
    this.mysterySolvedRoute.Register(solvedPoint);
    return true;
}

- メモリーミステリーを解くためには正しい鍵(メモリーミステリーキー)が必要
- メモリーミステリーキーはギミックを正しい順番で解いていかないと手に入らない
- ギミックを解くにはギミックキーが必要になる。

- ギミックキーはステージ内で手に入る
- いくつかのギミックを解いて,ミステリーキーを手に入れ,ミステリーを解いて、記憶を入手してステージを変化させ,出口を生み出し脱出を目指す。

## コード
player = new Player(Brain brain);

StageParts Player.FrashBack(Memory memory) {
    memory.CreateStageParts(playerResolvedRoute);
}

void Stage.ChangeStractureBy(MemoryID memoryId){
    player.FrashBack(Memor)
}

記憶を見つけるとステージの形が変化する


detectivePlayer.Get


## TODO テスト
Myteryをabstract class にして認証方法に柔軟性を持たせてみてはどうか？
　複合型のMystery(いくつかのMysteryオブジェクトを含んでいて、それら全てが解かれるか、どれか一つが解かれるかで解除される)などに耐久するため

Mysteryが認証するSolvedMysteryのデータ構造をどうすれば良いか？
　各Mysteryは解かれるべき一つ前のMysteryのIDを所有していて、渡されたSolvedMysteryがそのIdを持っていたら認証するとかはどうか？
　以前の謎が複合型のMysteryの場合はどうするか？
    SolvedMysteryにMysteryのグループIdを持たせてみてはどうか？

SolvedRouteはSolvedMysteryを登録できる
    solvedRoute.AddNew(solvedMystery) == true;
SolvedRouteはすでにあるSolvedMysteryは登録できない
    solvedRoute.AddNew(solvedMystery) == false;
SolvedRouteは一番上のsolvedMysteryを取得できる
　　 solvedRoute.Last();


Playerは謎を解くことができる
　　 player.Solve(mystery)
        鍵はいつ保有するか？
        鍵をメソッドでPlayerに渡すという方法もあるが、副作用の問題や低凝集の問題もある
        ならコンストラクタでKeyを渡すのがいいんじゃないか？
        インベントリなどでプレイヤーが鍵を指定するたびにplayerのインスタンス化を行うのか？
        コンストラクタでPlayerItemRepositoryを入れておく
            new Player(playerItemRepository);
            プレイヤーは鍵を選択できる。 
            void Player.Obtain(Key key){
                this.playerItemRepository.save(key);
            }

        鍵は
        


## 疑問に思ったこと

謎が正しく解かれることよりも、記憶が正しく手に入ることの方が重要なのでは？
謎が鍵を認証するのもそうだが、まずは記憶がプレイヤーの謎解き手順を正しく認証するのが良いのでは？
記憶自身がプレイヤーの謎解き手順を認証して,ステージを変えればいいのでは？

Memory memory = new Memory(stage);
stage = memory.Authenticate(MysterySolvedRoute);
private Stage Memory.Merge(Stage stage);


SolvedMysteryは新しい記憶を開放するために使われる
SolvedMysteryは謎がプレイヤーを認証する際に使用する
SolvedMysteryは謎がプレイヤーを認証して成功した結果生成される


謎を解くコンテキストにおいて、鍵が選択されている状態は必須か？別に選択している鍵を引数とかに渡せばいいんでは？
    それはその通り。ただ最新のSolvedMysteryをPlayerが保持するようになるため、どのみちplayerの副作用は避けられない。
    ならもう鍵をインベントリから選択するメソットを追加してみてはどうか
    


複合型の謎に


記憶を手に入れるためのSolvedMystery

Solve(MyseteryWithKeyID)