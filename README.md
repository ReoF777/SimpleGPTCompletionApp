# SimpleGPTCompletionApp

このリポジトリは、`WinForms`と`dotnet-openai`ライブラリを使用して、OpenAIのGPT-4 APIとチャットを行うアプリケーションです。

## 機能

- ユーザーはアプリケーションのUIを使用して、GPT-4oとチャットを行うことができます。
- OpenAIのAPIキーを設定して、APIリクエストを行います。
- シンプルで使いやすいUI。

## スクリーンショット

（ここにアプリのスクリーンショットを追加）

## 必要条件

- .NET 8.0 以上
- OpenAI APIキーが保存されたテキストファイル

## インストール手順

1. このリポジトリをクローンします。

    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    cd your-repo-name
    ```

2. 必要なパッケージをインストールします。

    - `dotnet-openai`ライブラリをNuGetからインストールします。

    ```bash
    dotnet add package OpenAI --version 1.4.0
    ```
    
3. プロジェクトをビルドします。

    ```bash
    dotnet build
    ```

4. アプリケーションを実行します。

    ```bash
    dotnet run
    ```

## 使い方

1. アプリケーションを起動すると、apiキーのファイルを選択するウィンドウが表示されます。
1. キーの入ったファイルを選択すると、チャットウィンドウが表示されます。
2. メッセージ入力欄にテキストを入力し、「送信」ボタンをクリックすると、GPT-4が応答します。
3. OpenAI APIとの通信は`dotnet-openai`ライブラリを介して行われます。

