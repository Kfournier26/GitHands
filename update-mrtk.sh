#!/bin/bash
ASSETDIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
TEMPDIR="$(mktemp -d)"
MRTK_GIT_URL="https://github.com/Microsoft/MixedRealityToolkit-Unity.git"
MRTK_DIRS=("HoloToolkit" "HoloToolkit-Examples" "HoloToolkit-Preview")


echo "$ASSETDIR"

while [ "$(basename "$ASSETDIR")" != "Assets" ]
do
	ASSETDIR="$(dirname "$ASSETDIR")"
done

git clone --depth 1 "$MRTK_GIT_URL" "$TEMPDIR"

for d in "${MRTK_DIRS[@]}"
do
	echo "Updating $d"
	if [ -d "$ASSETDIR/$d" ]; then
		rm -r "$ASSETDIR/$d"
	fi

	mv "$TEMPDIR/Assets/$d" "$ASSETDIR"
done


echo "Deleting temp directory ($TEMPDIR)"
rm -rf "$TEMPDIR"

echo "Done :)"

read -n 1 -s -r -p "Press any key to continue"