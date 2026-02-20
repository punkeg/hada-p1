P1: Which branch exactly has been uploaded? The master branch was uploaded.


P2: What happens when using the Compare option with the unmodified version? Visual Studio opens a side-by-side view showing the differences between your current code and the last version saved in the repository.

P3: And now you see any changes in the remote repository? Why? No, because you only performed a "Commit" (local) and haven't performed a "Push" (remote) yet.


P4: What does it mean "Confirm all" and what would the equivalent git command be? It saves all current changes to the local repository. Equivalent: git commit -a -m "message".


P5: What does it mean to "Confirm all and insert" and what would the equivalent git command be? It commits changes locally and then immediately uploads them to the remote server. Equivalent: git commit -a followed by git push.


P6: What does it mean to "Confirm all and synchronize" what would be the equivalent git command? It performs a Pull (to get remote changes) and then a Push (to upload yours) in one step. Equivalent: git commit -a, git pull, and git push.

P7: What is the difference between clicking Sync or Extract? What would the equivalent git commands be? "Sync" (Sincronizar) does both a pull and a push, while "Extract" (Extraer) only brings remote changes into your local branch. Equivalents: git pull vs git fetch.
